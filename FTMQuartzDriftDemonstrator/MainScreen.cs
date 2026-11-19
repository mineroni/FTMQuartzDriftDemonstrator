namespace FTMQuartzDriftDemonstrator;
using System.IO.Ports;

public partial class MainScreen : Form
{
    bool do_connect = false;
    string save_path = $"%temp%\\FTM_Demonstrator\\logfile{DateTime.Now:yyyyMMdd_HHmmss}.txt";
    SerialPort serialPort = new SerialPort();
    StreamWriter? logWriter;
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
        do_connect = true;
        string comPortName;
        using (ComPortSelectorDialog cpDialog = new ComPortSelectorDialog(SerialPort.GetPortNames()))
        {
            if (cpDialog.ShowDialog() != DialogResult.OK || !SerialPort.GetPortNames().Contains(cpDialog.SelectedComPort))
                return;
            comPortName = cpDialog.SelectedComPort;
            if (cpDialog.SaveLocation != string.Empty && Directory.Exists(Path.GetDirectoryName(cpDialog.SaveLocation)))
            {
                save_path = cpDialog.SaveLocation;
                logWriter = new StreamWriter(save_path, true) { AutoFlush = true };
            }
        }
        serialPort?.Close();
        serialPort = new SerialPort(comPortName, 115200, Parity.None, 8, StopBits.One);
        serialPort.DataReceived += serialDataReceived;
        try
        {
            if (!serialPort.IsOpen)
                serialPort.Open();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Serial connection failed: {ex.Message}");
        }
    }

    private void closeConnectionToolStripMenuItem_Click(object sender, EventArgs e)
    {
        do_connect = false;
        if (serialPort?.IsOpen == true)
            serialPort.Close();
    }
    private void serialDataReceived(object sender, EventArgs e)
    {
        string data = serialPort.ReadExisting();

        BeginInvoke(new Action(() =>
        {

        }));
    }
}
