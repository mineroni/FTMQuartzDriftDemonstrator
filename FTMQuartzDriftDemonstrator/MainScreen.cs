using System.IO.Ports;

namespace FTMQuartzDriftDemonstrator;

public partial class MainForm : Form
{
    const string version_number = "1.0";
    string save_path = string.Empty;
    SerialPort serialPort = new();
    StreamWriter? logWriter;
    object writeLock = new();
    private ScottPlot.Plottables.DataLogger quartzDriftPlotLogger;
    private ScottPlot.Plottables.DataLogger compensationValuePlotLogger;
    private ScottPlot.Plottables.DataLogger temperaturePlotLogger;
    private bool serialConnected = false;
    public MainForm()
    {
        InitializeComponent();
        string? dirpath = Path.GetDirectoryName(save_path);
        if (dirpath != null && !Directory.Exists(dirpath))
            Directory.CreateDirectory(dirpath);
        setConnectionStatus(false);
        quartzDriftPlotLogger = quartzDriftPlot.Plot.Add.DataLogger();
        quartzDriftPlotLogger.ViewSlide(100);
        quartzDriftPlot.Plot.Axes.Bottom.TickLabelStyle.FontSize = 12;
        quartzDriftPlot.Plot.Axes.Left.TickLabelStyle.FontSize = 12;
        quartzDriftPlot.Plot.Axes.Bottom.Label.FontSize = 14;
        quartzDriftPlot.Plot.Axes.Left.Label.FontSize = 14;
        quartzDriftPlotLogger.LineStyle.Width = 4;
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        serialPort?.Close();
        Application.Exit();
    }

    private void connectToolStripMenuItem_Click(object sender, EventArgs e)
    {
        string comPortName;
        using (ComPortSelectorDialog cpDialog = new ComPortSelectorDialog(SerialPort.GetPortNames()))
        {
            if (cpDialog.ShowDialog() != DialogResult.OK)
                return;

            if (save_path == string.Empty || save_path.StartsWith($"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\Temp\\FTM_Demonstrator"))
                save_path = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\Temp\\FTM_Demonstrator\\logfile_{DateTime.Now:yyyy_MM_dd_HHmmss}.txt";
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
            lock (writeLock)
            {
                logWriter?.Close();
                logWriter = new StreamWriter(save_path, true) { AutoFlush = true };
                logWriter.WriteLine($"FTM Quartz Drift Denonstrator V{version_number}");
            }

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
            return;
        }
        serialConnected = true;
        Task.Run(() =>
        {
            while (serialConnected)
            {
                try
                {
                    if (!serialPort.IsOpen)
                        serialPort.Open();

                    string line = serialPort.ReadLine();
                    Invoke(serialDataReceived, line);
                }
                catch (TimeoutException)
                {
                    // No complete line received within timeout.
                }
                catch (Exception)
                {
                    Thread.Sleep(100);
                    // Serial port closed or other error occurred.
                }
            }
        });
        setConnectionStatus(true);
    }

    private void setConnectionStatus(bool connected)
    {
        openLogToolStripMenuItem.Enabled = !connected;
        connectToolStripMenuItem.Enabled = !connected;
        saveLogAsToolStripMenuItem.Enabled = connected;
        closeConnectionToolStripMenuItem.Enabled = connected;
        bReset.Enabled = connected;
        bCompOff.Enabled = connected;
        bCompOn.Enabled = connected;
    }

    private void closeConnectionToolStripMenuItem_Click(object sender, EventArgs e)
    {
        serialConnected = false;
        if (serialPort?.IsOpen == true)
            serialPort.Close();
        lock (writeLock)
            logWriter?.Close();

        setConnectionStatus(false);
        quartzDriftPlotLogger.Clear();
        quartzDriftPlot.Refresh();
        lCompValue.Text = "0.00 ppm";
        lCompValue.ForeColor = Color.Red;
        lInitatorTemperature.Text = "0 °C";
        lInitatorTemperature.ForeColor = Color.Red;
        lResponderTemperature.Text = "0 °C";
        lResponderTemperature.ForeColor = Color.Red;
        lConnectionRSSI.Text = "0 dBm";
        lConnectionRSSI.ForeColor = Color.Red;
        lEstimatedDistance.Text = "00 cm";
        lEstimatedDistance.ForeColor = Color.Red;
        lEstimatedRTT.Text = "0 ns";
        lEstimatedRTT.ForeColor = Color.Red;
        lCurrentQuartzDrift.Text = "0.00 ppm";
        lCurrentQuartzDrift.ForeColor = Color.Red;
        lCompensationState.Text = "OFF";
        lCompensationState.ForeColor = Color.Red;
    }

    private void serialDataReceived(string lineReceived)
    {
        lock (writeLock)
            if (serialConnected)
                logWriter?.WriteLine(lineReceived);

        // Data measurement report messages
        if (lineReceived.StartsWith("data;"))
        {
            MeassurementData_V1 currentMeassurementValues;
            try
            {
                currentMeassurementValues = new(lineReceived);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\n{ex.InnerException?.Message}", "Data parsing failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (quartzDriftPlotLogger.Data.Coordinates.Count > 0 && quartzDriftPlotLogger.Data.Coordinates.Last().X > currentMeassurementValues.timeSec)
                quartzDriftPlotLogger.Clear();
            quartzDriftPlotLogger.Add(currentMeassurementValues.timeSec, currentMeassurementValues.currentQuartzDriftPPM);
            quartzDriftPlot.Refresh();

            lCompValue.Text = $"{currentMeassurementValues.compPPM:F2} ppm";
            lCompValue.ForeColor = currentMeassurementValues.compPPMColor;
            lInitatorTemperature.Text = $"{currentMeassurementValues.initiatorTempCelsius} °C";
            lInitatorTemperature.ForeColor = currentMeassurementValues.initiatorTempColor;
            lResponderTemperature.Text = $"{currentMeassurementValues.responderTempCelsius} °C";
            lResponderTemperature.ForeColor = currentMeassurementValues.responderTempColor;
            lConnectionRSSI.Text = $"{currentMeassurementValues.rssi} dBm";
            lConnectionRSSI.ForeColor = currentMeassurementValues.rssiColor;
            lCurrentQuartzDrift.Text = $"{currentMeassurementValues.currentQuartzDriftPPM:F2} ppm";
            lCurrentQuartzDrift.ForeColor = currentMeassurementValues.quartzDriftColor;
        }
        // Standard FTM report messages
        else if (lineReceived.Contains("FTM report:"))
        {
            FTMData_V1 currentFTMData;
            try
            {
                currentFTMData = new(lineReceived);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\n{ex.InnerException?.Message}", "Data parsing failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lEstimatedDistance.Text = $"{currentFTMData.estimatedDistance} cm";
            lEstimatedDistance.ForeColor = currentFTMData.estimatedDistanceColor;
            lEstimatedRTT.Text = $"{currentFTMData.rttEstimated} ns";
            lEstimatedRTT.ForeColor = currentFTMData.rttEstimatedColor;
        }
        // Uart response commands
        else if (lineReceived.Contains("uart;"))
        {
            if (lineReceived.Contains("uart;comp_on"))
            {
                lCompensationState.Text = "ON";
                lCompensationState.ForeColor = Color.Green;
            }
            else if (lineReceived.Contains("uart;comp_off"))
            {
                lCompensationState.Text = "OFF";
                lCompensationState.ForeColor = Color.Red;
            }
        }
    }

    private void openLogToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using (OpenFileDialog dialog = new())
        {
            dialog.Title = "Open logfile...";
            dialog.Filter = "Response log files (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.DefaultExt = "txt";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (dialog.ShowDialog() == DialogResult.OK && File.Exists(dialog.FileName))
            {
                lock (writeLock)
                {
                    logWriter?.Close();
                    save_path = dialog.FileName;
                    try
                    {
                        using (StreamReader sr = new(save_path))
                        {
                            foreach (string line in sr.ReadToEnd().Split(Environment.NewLine))
                            {
                                if (!line.StartsWith("data;"))
                                    continue;
                                MeassurementData_V1 currentMeassuremntValues;
                                try
                                {
                                    currentMeassuremntValues = new(line);
                                    quartzDriftPlotLogger.Add(currentMeassuremntValues.timeSec, currentMeassuremntValues.currentQuartzDriftPPM);
                                }
                                catch (Exception) { }
                            }
                        }
                        quartzDriftPlot.Refresh();
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show($"There were no output file created yet!\n{ex.Message}", "Output file was not created!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    logWriter = new StreamWriter(save_path, true) { AutoFlush = true };
                }
            }
        }
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

            if (dialog.ShowDialog() == DialogResult.OK && Directory.Exists(Path.GetDirectoryName(dialog.FileName)))
            {
                lock (writeLock)
                {
                    logWriter?.Close();
                    try
                    {
                        File.Copy(save_path, dialog.FileName, true);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show($"There were no output file created yet!\n{ex.Message}", "Output file was not created!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    logWriter = new StreamWriter(save_path, true) { AutoFlush = true };
                }
            }
        }
    }

    private void bCompOff_Click(object sender, EventArgs e) => serialPort?.WriteLine("command;comp_off");

    private void bCompOn_Click(object sender, EventArgs e) => serialPort?.WriteLine("command;comp_on");

    private void bReset_Click(object sender, EventArgs e) => serialPort?.WriteLine("command;reset");
}
