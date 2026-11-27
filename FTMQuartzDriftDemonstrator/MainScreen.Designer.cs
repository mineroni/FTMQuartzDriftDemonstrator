namespace FTMQuartzDriftDemonstrator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            connectToolStripMenuItem = new ToolStripMenuItem();
            openLogToolStripMenuItem = new ToolStripMenuItem();
            saveLogAsToolStripMenuItem = new ToolStripMenuItem();
            closeConnectionToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            pRight = new Panel();
            lCompensationState = new Label();
            lCompensationState_tag = new Label();
            bReset = new Button();
            lEstimatedRTT = new Label();
            lEstimatedRTT_tag = new Label();
            lEstimatedDistance = new Label();
            lEstimatedDistance_tag = new Label();
            lConnectionRSSI = new Label();
            lConnectionRSSI_tag = new Label();
            lResponderTemperature = new Label();
            lResponderTemperature_tag = new Label();
            lInitatorTemperature = new Label();
            lInitiatorTemperature_tag = new Label();
            lCurrentQuartzDrift = new Label();
            lCurrentQuartzDrift_tag = new Label();
            lCompValue = new Label();
            lCompValue_tag = new Label();
            bCompOn = new Button();
            bCompOff = new Button();
            quartzDriftPlot = new ScottPlot.WinForms.FormsPlot();
            tabControl = new TabControl();
            tpQuartDrift = new TabPage();
            tpCompensationValue = new TabPage();
            compensationValuePlot = new ScottPlot.WinForms.FormsPlot();
            tpTempGraph = new TabPage();
            tpConsoleOut = new TabPage();
            rtbConsole = new RichTextBox();
            menuStrip.SuspendLayout();
            pRight.SuspendLayout();
            tabControl.SuspendLayout();
            tpQuartDrift.SuspendLayout();
            tpCompensationValue.SuspendLayout();
            tpConsoleOut.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, exitToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(5, 2, 0, 2);
            menuStrip.RenderMode = ToolStripRenderMode.Professional;
            menuStrip.Size = new Size(934, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { connectToolStripMenuItem, openLogToolStripMenuItem, saveLogAsToolStripMenuItem, closeConnectionToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // connectToolStripMenuItem
            // 
            connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            connectToolStripMenuItem.Size = new Size(166, 22);
            connectToolStripMenuItem.Text = "Connect";
            connectToolStripMenuItem.Click += connectToolStripMenuItem_Click;
            // 
            // openLogToolStripMenuItem
            // 
            openLogToolStripMenuItem.Name = "openLogToolStripMenuItem";
            openLogToolStripMenuItem.Size = new Size(166, 22);
            openLogToolStripMenuItem.Text = "Open log";
            openLogToolStripMenuItem.Click += openLogToolStripMenuItem_Click;
            // 
            // saveLogAsToolStripMenuItem
            // 
            saveLogAsToolStripMenuItem.Name = "saveLogAsToolStripMenuItem";
            saveLogAsToolStripMenuItem.Size = new Size(166, 22);
            saveLogAsToolStripMenuItem.Text = "Save log as...";
            saveLogAsToolStripMenuItem.Click += saveLogAsToolStripMenuItem_Click;
            // 
            // closeConnectionToolStripMenuItem
            // 
            closeConnectionToolStripMenuItem.Name = "closeConnectionToolStripMenuItem";
            closeConnectionToolStripMenuItem.Size = new Size(166, 22);
            closeConnectionToolStripMenuItem.Text = "Close connection";
            closeConnectionToolStripMenuItem.Click += closeConnectionToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(37, 20);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // pRight
            // 
            pRight.Controls.Add(lCompensationState);
            pRight.Controls.Add(lCompensationState_tag);
            pRight.Controls.Add(bReset);
            pRight.Controls.Add(lEstimatedRTT);
            pRight.Controls.Add(lEstimatedRTT_tag);
            pRight.Controls.Add(lEstimatedDistance);
            pRight.Controls.Add(lEstimatedDistance_tag);
            pRight.Controls.Add(lConnectionRSSI);
            pRight.Controls.Add(lConnectionRSSI_tag);
            pRight.Controls.Add(lResponderTemperature);
            pRight.Controls.Add(lResponderTemperature_tag);
            pRight.Controls.Add(lInitatorTemperature);
            pRight.Controls.Add(lInitiatorTemperature_tag);
            pRight.Controls.Add(lCurrentQuartzDrift);
            pRight.Controls.Add(lCurrentQuartzDrift_tag);
            pRight.Controls.Add(lCompValue);
            pRight.Controls.Add(lCompValue_tag);
            pRight.Controls.Add(bCompOn);
            pRight.Controls.Add(bCompOff);
            pRight.Dock = DockStyle.Right;
            pRight.Location = new Point(754, 24);
            pRight.Name = "pRight";
            pRight.Size = new Size(180, 648);
            pRight.TabIndex = 1;
            // 
            // lCompensationState
            // 
            lCompensationState.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lCompensationState.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lCompensationState.ForeColor = Color.Red;
            lCompensationState.Location = new Point(3, 530);
            lCompensationState.Name = "lCompensationState";
            lCompensationState.Size = new Size(175, 32);
            lCompensationState.TabIndex = 18;
            lCompensationState.Text = "OFF";
            lCompensationState.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lCompensationState_tag
            // 
            lCompensationState_tag.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lCompensationState_tag.Location = new Point(3, 500);
            lCompensationState_tag.Name = "lCompensationState_tag";
            lCompensationState_tag.Size = new Size(175, 21);
            lCompensationState_tag.TabIndex = 17;
            lCompensationState_tag.Text = "Compensation State";
            // 
            // bReset
            // 
            bReset.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            bReset.Location = new Point(6, 570);
            bReset.Name = "bReset";
            bReset.Size = new Size(169, 24);
            bReset.TabIndex = 16;
            bReset.Text = "Reset";
            bReset.UseVisualStyleBackColor = true;
            bReset.Click += bReset_Click;
            // 
            // lEstimatedRTT
            // 
            lEstimatedRTT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lEstimatedRTT.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lEstimatedRTT.ForeColor = Color.Red;
            lEstimatedRTT.Location = new Point(3, 390);
            lEstimatedRTT.Name = "lEstimatedRTT";
            lEstimatedRTT.Size = new Size(175, 32);
            lEstimatedRTT.TabIndex = 15;
            lEstimatedRTT.Text = "0 ns";
            lEstimatedRTT.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lEstimatedRTT_tag
            // 
            lEstimatedRTT_tag.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lEstimatedRTT_tag.Location = new Point(3, 360);
            lEstimatedRTT_tag.Name = "lEstimatedRTT_tag";
            lEstimatedRTT_tag.Size = new Size(175, 21);
            lEstimatedRTT_tag.TabIndex = 14;
            lEstimatedRTT_tag.Text = "Estimated RTT:";
            // 
            // lEstimatedDistance
            // 
            lEstimatedDistance.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lEstimatedDistance.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lEstimatedDistance.ForeColor = Color.Red;
            lEstimatedDistance.Location = new Point(3, 320);
            lEstimatedDistance.Name = "lEstimatedDistance";
            lEstimatedDistance.Size = new Size(175, 32);
            lEstimatedDistance.TabIndex = 13;
            lEstimatedDistance.Text = "00 cm";
            lEstimatedDistance.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lEstimatedDistance_tag
            // 
            lEstimatedDistance_tag.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lEstimatedDistance_tag.Location = new Point(3, 290);
            lEstimatedDistance_tag.Name = "lEstimatedDistance_tag";
            lEstimatedDistance_tag.Size = new Size(175, 21);
            lEstimatedDistance_tag.TabIndex = 12;
            lEstimatedDistance_tag.Text = "Estimated distance:";
            // 
            // lConnectionRSSI
            // 
            lConnectionRSSI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lConnectionRSSI.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lConnectionRSSI.ForeColor = Color.Red;
            lConnectionRSSI.Location = new Point(3, 250);
            lConnectionRSSI.Name = "lConnectionRSSI";
            lConnectionRSSI.Size = new Size(175, 32);
            lConnectionRSSI.TabIndex = 11;
            lConnectionRSSI.Text = "-00 dBm";
            lConnectionRSSI.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lConnectionRSSI_tag
            // 
            lConnectionRSSI_tag.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lConnectionRSSI_tag.Location = new Point(3, 220);
            lConnectionRSSI_tag.Name = "lConnectionRSSI_tag";
            lConnectionRSSI_tag.Size = new Size(175, 21);
            lConnectionRSSI_tag.TabIndex = 10;
            lConnectionRSSI_tag.Text = "Connection RSSI:";
            // 
            // lResponderTemperature
            // 
            lResponderTemperature.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lResponderTemperature.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lResponderTemperature.ForeColor = Color.Red;
            lResponderTemperature.Location = new Point(3, 180);
            lResponderTemperature.Name = "lResponderTemperature";
            lResponderTemperature.Size = new Size(175, 32);
            lResponderTemperature.TabIndex = 9;
            lResponderTemperature.Text = "00 °C";
            lResponderTemperature.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lResponderTemperature_tag
            // 
            lResponderTemperature_tag.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lResponderTemperature_tag.Location = new Point(3, 150);
            lResponderTemperature_tag.Name = "lResponderTemperature_tag";
            lResponderTemperature_tag.Size = new Size(178, 21);
            lResponderTemperature_tag.TabIndex = 8;
            lResponderTemperature_tag.Text = "Responder temperature:";
            // 
            // lInitatorTemperature
            // 
            lInitatorTemperature.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lInitatorTemperature.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lInitatorTemperature.ForeColor = Color.Red;
            lInitatorTemperature.Location = new Point(3, 110);
            lInitatorTemperature.Name = "lInitatorTemperature";
            lInitatorTemperature.Size = new Size(175, 32);
            lInitatorTemperature.TabIndex = 7;
            lInitatorTemperature.Text = "00 °C";
            lInitatorTemperature.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lInitiatorTemperature_tag
            // 
            lInitiatorTemperature_tag.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lInitiatorTemperature_tag.Location = new Point(3, 80);
            lInitiatorTemperature_tag.Name = "lInitiatorTemperature_tag";
            lInitiatorTemperature_tag.Size = new Size(175, 21);
            lInitiatorTemperature_tag.TabIndex = 6;
            lInitiatorTemperature_tag.Text = "Initiator temperature";
            // 
            // lCurrentQuartzDrift
            // 
            lCurrentQuartzDrift.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lCurrentQuartzDrift.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lCurrentQuartzDrift.ForeColor = Color.Red;
            lCurrentQuartzDrift.Location = new Point(3, 460);
            lCurrentQuartzDrift.Name = "lCurrentQuartzDrift";
            lCurrentQuartzDrift.Size = new Size(175, 32);
            lCurrentQuartzDrift.TabIndex = 5;
            lCurrentQuartzDrift.Text = "0.00 ppm";
            lCurrentQuartzDrift.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lCurrentQuartzDrift_tag
            // 
            lCurrentQuartzDrift_tag.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lCurrentQuartzDrift_tag.Location = new Point(3, 430);
            lCurrentQuartzDrift_tag.Name = "lCurrentQuartzDrift_tag";
            lCurrentQuartzDrift_tag.Size = new Size(175, 21);
            lCurrentQuartzDrift_tag.TabIndex = 4;
            lCurrentQuartzDrift_tag.Text = "Current quartz drift:";
            // 
            // lCompValue
            // 
            lCompValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lCompValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lCompValue.ForeColor = Color.Red;
            lCompValue.Location = new Point(3, 40);
            lCompValue.Name = "lCompValue";
            lCompValue.Size = new Size(175, 32);
            lCompValue.TabIndex = 3;
            lCompValue.Text = "0.00 ppm";
            lCompValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lCompValue_tag
            // 
            lCompValue_tag.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lCompValue_tag.Location = new Point(3, 10);
            lCompValue_tag.Name = "lCompValue_tag";
            lCompValue_tag.Size = new Size(175, 21);
            lCompValue_tag.TabIndex = 2;
            lCompValue_tag.Text = "Compensation value:";
            // 
            // bCompOn
            // 
            bCompOn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bCompOn.Location = new Point(100, 600);
            bCompOn.Name = "bCompOn";
            bCompOn.Size = new Size(75, 40);
            bCompOn.TabIndex = 1;
            bCompOn.Text = "Turn on Comp";
            bCompOn.UseVisualStyleBackColor = true;
            bCompOn.Click += bCompOn_Click;
            // 
            // bCompOff
            // 
            bCompOff.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            bCompOff.Location = new Point(6, 600);
            bCompOff.Name = "bCompOff";
            bCompOff.Size = new Size(75, 40);
            bCompOff.TabIndex = 0;
            bCompOff.Text = "Turn off Comp";
            bCompOff.UseVisualStyleBackColor = true;
            bCompOff.Click += bCompOff_Click;
            // 
            // quartzDriftPlot
            // 
            quartzDriftPlot.Dock = DockStyle.Fill;
            quartzDriftPlot.Location = new Point(3, 3);
            quartzDriftPlot.Name = "quartzDriftPlot";
            quartzDriftPlot.Size = new Size(740, 614);
            quartzDriftPlot.TabIndex = 2;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tpQuartDrift);
            tabControl.Controls.Add(tpCompensationValue);
            tabControl.Controls.Add(tpTempGraph);
            tabControl.Controls.Add(tpConsoleOut);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 24);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(754, 648);
            tabControl.TabIndex = 3;
            // 
            // tpQuartDrift
            // 
            tpQuartDrift.Controls.Add(quartzDriftPlot);
            tpQuartDrift.Location = new Point(4, 24);
            tpQuartDrift.Name = "tpQuartDrift";
            tpQuartDrift.Padding = new Padding(3);
            tpQuartDrift.Size = new Size(746, 620);
            tpQuartDrift.TabIndex = 0;
            tpQuartDrift.Text = "Quartz drift graph";
            tpQuartDrift.UseVisualStyleBackColor = true;
            // 
            // tpCompensationValue
            // 
            tpCompensationValue.Controls.Add(compensationValuePlot);
            tpCompensationValue.Location = new Point(4, 24);
            tpCompensationValue.Name = "tpCompensationValue";
            tpCompensationValue.Padding = new Padding(3);
            tpCompensationValue.Size = new Size(746, 620);
            tpCompensationValue.TabIndex = 1;
            tpCompensationValue.Text = "Compensation value graph";
            tpCompensationValue.UseVisualStyleBackColor = true;
            // 
            // compensationValuePlot
            // 
            compensationValuePlot.Dock = DockStyle.Fill;
            compensationValuePlot.Location = new Point(3, 3);
            compensationValuePlot.Name = "compensationValuePlot";
            compensationValuePlot.Size = new Size(740, 614);
            compensationValuePlot.TabIndex = 0;
            // 
            // tpTempGraph
            // 
            tpTempGraph.Location = new Point(4, 24);
            tpTempGraph.Name = "tpTempGraph";
            tpTempGraph.Size = new Size(746, 620);
            tpTempGraph.TabIndex = 2;
            tpTempGraph.Text = "Temperatures graph";
            tpTempGraph.UseVisualStyleBackColor = true;
            // 
            // tpConsoleOut
            // 
            tpConsoleOut.Controls.Add(rtbConsole);
            tpConsoleOut.Location = new Point(4, 24);
            tpConsoleOut.Name = "tpConsoleOut";
            tpConsoleOut.Size = new Size(746, 620);
            tpConsoleOut.TabIndex = 3;
            tpConsoleOut.Text = "Console";
            tpConsoleOut.UseVisualStyleBackColor = true;
            // 
            // rtbConsole
            // 
            rtbConsole.Dock = DockStyle.Fill;
            rtbConsole.Location = new Point(0, 0);
            rtbConsole.Name = "rtbConsole";
            rtbConsole.ReadOnly = true;
            rtbConsole.Size = new Size(746, 620);
            rtbConsole.TabIndex = 0;
            rtbConsole.Text = "";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(934, 672);
            Controls.Add(tabControl);
            Controls.Add(pRight);
            Controls.Add(menuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "FTM Quartz Drift Demonstrator";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            pRight.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            tpQuartDrift.ResumeLayout(false);
            tpCompensationValue.ResumeLayout(false);
            tpConsoleOut.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem connectToolStripMenuItem;
        private ToolStripMenuItem openLogToolStripMenuItem;
        private ToolStripMenuItem saveLogAsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem closeConnectionToolStripMenuItem;
        private Panel pRight;
        private ScottPlot.WinForms.FormsPlot quartzDriftPlot;
        private Button bCompOn;
        private Button bCompOff;
        private Label lCompValue_tag;
        private Label lCompValue;
        private Label lCurrentQuartzDrift;
        private Label lCurrentQuartzDrift_tag;
        private Label lResponderTemperature;
        private Label lResponderTemperature_tag;
        private Label lInitatorTemperature;
        private Label lInitiatorTemperature_tag;
        private Label lConnectionRSSI;
        private Label lConnectionRSSI_tag;
        private Label lEstimatedDistance;
        private Label lEstimatedDistance_tag;
        private Label lEstimatedRTT;
        private Label lEstimatedRTT_tag;
        private Button bReset;
        private Label lCompensationState;
        private Label lCompensationState_tag;
        private TabControl tabControl;
        private TabPage tpQuartDrift;
        private TabPage tpCompensationValue;
        private ScottPlot.WinForms.FormsPlot compensationValuePlot;
        private TabPage tpTempGraph;
        private TabPage tpConsoleOut;
        private RichTextBox rtbConsole;
    }
}