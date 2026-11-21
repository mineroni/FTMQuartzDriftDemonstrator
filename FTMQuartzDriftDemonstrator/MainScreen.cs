namespace FTMQuartzDriftDemonstrator;
using System.IO.Ports;

public partial class MainScreen : Form
{
    const string version_number = "1.0";
    string save_path = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\Temp\\FTM_Demonstrator\\logfile_{DateTime.Now:yyyy_MM_dd_HHmmss}.txt";
    SerialPort serialPort = new();
    StreamWriter? logWriter;
    object writeLock = new();
    public MainScreen()
    {
        InitializeComponent();
        string? dirpath = Path.GetDirectoryName(save_path);
        if (dirpath != null && !Directory.Exists(dirpath))
            Directory.CreateDirectory(dirpath);
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

    private void connectToolStripMenuItem_Click(object sender, EventArgs e)
    {
        string comPortName;
        using (ComPortSelectorDialog cpDialog = new ComPortSelectorDialog(SerialPort.GetPortNames()))
        {
            if (cpDialog.ShowDialog() != DialogResult.OK)
                return;

            if (cpDialog.SaveLocation != string.Empty)
            {
                if (Directory.Exists(Path.GetDirectoryName(cpDialog.SaveLocation)))
                {
                    save_path = cpDialog.SaveLocation;
                }
                else
                {
                    MessageBox.Show("The selected save path is not valid!", "Save path is not valid!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            logWriter = new StreamWriter(save_path, true) { AutoFlush = true };
            logWriter.WriteLine($"FTM Quartz Drift Denonstrator V{version_number}");

            if (!SerialPort.GetPortNames().Contains(cpDialog.SelectedComPort))
            {
                MessageBox.Show("The selected COM port can not be found!", "COM port can not be found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            comPortName = cpDialog.SelectedComPort;
        }
        serialPort?.Close();
        serialPort = new SerialPort(comPortName, 115200, Parity.None, 8, StopBits.One);
        try
        {
            if (serialPort.IsOpen == false)
                serialPort.Open();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Serial connection failed!\n{ex.Message}", "Serial port could not be opened!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        Task.Run(() =>
        {
            while (serialPort.IsOpen)
            {
                try
                {
                    string line = serialPort.ReadLine();

                    Invoke(serialDataReceived, line);
                }
                catch (TimeoutException)
                {
                    // No complete line received within timeout.
                }
                catch (InvalidOperationException)
                {
                    break;
                }
                catch (IOException)
                {
                    break;
                }
            }
        });
    }

    private void closeConnectionToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (serialPort?.IsOpen == true)
            serialPort.Close();
    }

    private void serialDataReceived(string lineReceived)
    {
        logWriter?.Write(lineReceived);
        MessageBox.Show($"Line received!{lineReceived}");
        // Show it on the graph
    }

    private void openLogToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void saveLogAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using (SaveFileDialog dialog = new())
        {
            dialog.Title = "Save logfile as...";
            dialog.Filter = "Response log files (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.DefaultExt = "txt";
            dialog.FileName = "response_log.txt";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (dialog.ShowDialog() == DialogResult.OK && Directory.Exists(dialog.FileName))
            {
                lock (writeLock)
                {
                    logWriter?.Close();
                    File.Copy(save_path, dialog.FileName);
                    logWriter = new StreamWriter(save_path, true) { AutoFlush = true };
                }
            }
        }
    }
}
