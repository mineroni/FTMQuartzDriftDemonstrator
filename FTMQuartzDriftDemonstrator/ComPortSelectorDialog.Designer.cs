namespace FTMQuartzDriftDemonstrator
{
    partial class ComPortSelectorDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lComPort = new Label();
            cbComPort = new ComboBox();
            cbSaveLog = new CheckBox();
            tbSaveFilePath = new TextBox();
            bBrowse = new Button();
            lSaveLocation = new Label();
            bOK = new Button();
            SuspendLayout();
            // 
            // lComPort
            // 
            lComPort.AutoSize = true;
            lComPort.Location = new Point(12, 9);
            lComPort.Name = "lComPort";
            lComPort.Size = new Size(58, 15);
            lComPort.TabIndex = 0;
            lComPort.Text = "ComPort:";
            // 
            // cbComPort
            // 
            cbComPort.FormattingEnabled = true;
            cbComPort.Location = new Point(148, 6);
            cbComPort.Name = "cbComPort";
            cbComPort.Size = new Size(129, 23);
            cbComPort.TabIndex = 1;
            // 
            // cbSaveLog
            // 
            cbSaveLog.AutoSize = true;
            cbSaveLog.Location = new Point(12, 38);
            cbSaveLog.Name = "cbSaveLog";
            cbSaveLog.Size = new Size(69, 19);
            cbSaveLog.TabIndex = 2;
            cbSaveLog.Text = "saveLog";
            cbSaveLog.UseVisualStyleBackColor = true;
            cbSaveLog.CheckedChanged += cbSaveLog_CheckedChanged;
            // 
            // tbSaveFilePath
            // 
            tbSaveFilePath.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbSaveFilePath.Location = new Point(12, 88);
            tbSaveFilePath.Name = "tbSaveFilePath";
            tbSaveFilePath.Size = new Size(197, 23);
            tbSaveFilePath.TabIndex = 3;
            tbSaveFilePath.Visible = false;
            // 
            // bBrowse
            // 
            bBrowse.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bBrowse.Location = new Point(215, 88);
            bBrowse.Name = "bBrowse";
            bBrowse.Size = new Size(62, 23);
            bBrowse.TabIndex = 4;
            bBrowse.Text = "Browse";
            bBrowse.UseVisualStyleBackColor = true;
            bBrowse.Visible = false;
            bBrowse.Click += bBrowse_Click;
            // 
            // lSaveLocation
            // 
            lSaveLocation.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lSaveLocation.AutoSize = true;
            lSaveLocation.Location = new Point(12, 70);
            lSaveLocation.Name = "lSaveLocation";
            lSaveLocation.Size = new Size(77, 15);
            lSaveLocation.TabIndex = 5;
            lSaveLocation.Text = "Save location";
            lSaveLocation.Visible = false;
            // 
            // bOK
            // 
            bOK.Location = new Point(177, 35);
            bOK.Name = "bOK";
            bOK.Size = new Size(100, 40);
            bOK.TabIndex = 6;
            bOK.Text = "OK";
            bOK.UseVisualStyleBackColor = true;
            bOK.Click += button1_Click;
            // 
            // ComPortSelectorDialog
            // 
            AcceptButton = bOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 121);
            Controls.Add(bOK);
            Controls.Add(lSaveLocation);
            Controls.Add(bBrowse);
            Controls.Add(tbSaveFilePath);
            Controls.Add(cbSaveLog);
            Controls.Add(cbComPort);
            Controls.Add(lComPort);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new Size(305, 150);
            Name = "ComPortSelectorDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "ComPortSelector";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lComPort;
        private ComboBox cbComPort;
        private CheckBox cbSaveLog;
        private TextBox tbSaveFilePath;
        private Button bBrowse;
        private Label lSaveLocation;
        private Button bOK;
    }
}