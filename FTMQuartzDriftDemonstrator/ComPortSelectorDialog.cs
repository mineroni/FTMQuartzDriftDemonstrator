namespace FTMQuartzDriftDemonstrator;

public partial class ComPortSelectorDialog : Form
{
    //const int minHeightWithSavePath = 200;
    //const int minHeightWithoutSavePath = 180;
    const int minHeightWithSavePath = 150;
    const int minHeightWithoutSavePath = 120;
    public string SelectedComPort { get => cbComPort.SelectedItem?.ToString() ?? string.Empty; }
    public string SaveLocation { get => tbSaveFilePath.Text; }
    public ComPortSelectorDialog(string[] comPortNames)
    {
        InitializeComponent();
        cbComPort.Items.AddRange(comPortNames);
        if (cbComPort.Items.Count > 0)
            cbComPort.SelectedIndex = 0;
        MinimumSize = new Size(MinimumSize.Width, getDeviceSpecificDpiScalePixel(minHeightWithoutSavePath));
        Height = MinimumSize.Height;
    }

    int getDeviceSpecificDpiScalePixel(int pixel) => (int)(pixel * DeviceDpi / 96f);

    private void cbSaveLog_CheckedChanged(object sender, EventArgs e)
    {
        lSaveLocation.Visible = cbSaveLog.Checked;
        tbSaveFilePath.Visible = cbSaveLog.Checked;
        bBrowse.Visible = cbSaveLog.Checked;
        MinimumSize = new Size(MinimumSize.Width, getDeviceSpecificDpiScalePixel(cbSaveLog.Checked ? minHeightWithSavePath : minHeightWithoutSavePath));
        // If the window is allready bigger don't change it
        if (Size.Height <= getDeviceSpecificDpiScalePixel(minHeightWithSavePath))
            Height = MinimumSize.Height;

        // Set tb clear, if we don't want to save the file
        if (!cbSaveLog.Checked)
            tbSaveFilePath.Text = string.Empty;
    }

    private void bBrowse_Click(object sender, EventArgs e)
    {
        using (SaveFileDialog dialog = new())
        {
            dialog.Title = "Save logfile";
            dialog.Filter = "Response log files (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.DefaultExt = "txt";
            dialog.FileName = "response_log.txt";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (dialog.ShowDialog() == DialogResult.OK)
                tbSaveFilePath.Text = dialog.FileName;
        }
    }

    private void bOk_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.OK;
        Close();
    }
}
