namespace FTMQuartzDriftDemonstrator;

public partial class ComPortSelectorDialog : Form
{
    public string SelectedComPort { get => cbComPort.SelectedItem?.ToString() ?? string.Empty; }
    public string SaveLocation { get => tbSaveFilePath.Text; }
    public ComPortSelectorDialog(string[] comPortNames)
    {
        InitializeComponent();
        cbComPort.Items.AddRange(comPortNames);
        if (cbComPort.Items.Count > 0)
            cbComPort.SelectedIndex = 0;
    }

    private void cbSaveLog_CheckedChanged(object sender, EventArgs e)
    {
        lSaveLocation.Visible = cbSaveLog.Checked;
        tbSaveFilePath.Visible = cbSaveLog.Checked;
        bBrowse.Visible = cbSaveLog.Checked;
    }
}
