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
            Plot = new ScottPlot.WinForms.FormsPlot();
            menuStrip.SuspendLayout();
            pRight.SuspendLayout();
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
            pRight.Location = new Point(750, 24);
            pRight.Name = "pRight";
            pRight.Size = new Size(184, 490);
            pRight.TabIndex = 1;
            // 
            // lConnectionRSSI
            // 
            lConnectionRSSI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lConnectionRSSI.AutoSize = true;
            lConnectionRSSI.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lConnectionRSSI.ForeColor = Color.Red;
            lConnectionRSSI.Location = new Point(70, 250);
            lConnectionRSSI.Name = "lConnectionRSSI";
            lConnectionRSSI.Size = new Size(111, 32);
            lConnectionRSSI.TabIndex = 11;
            lConnectionRSSI.Text = "-00 dBm";
            // 
            // lConnectionRSSI_tag
            // 
            lConnectionRSSI_tag.AutoSize = true;
            lConnectionRSSI_tag.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lConnectionRSSI_tag.Location = new Point(3, 220);
            lConnectionRSSI_tag.Name = "lConnectionRSSI_tag";
            lConnectionRSSI_tag.Size = new Size(128, 21);
            lConnectionRSSI_tag.TabIndex = 10;
            lConnectionRSSI_tag.Text = "Connection RSSI:";
            // 
            // lResponderTemperature
            // 
            lResponderTemperature.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lResponderTemperature.AutoSize = true;
            lResponderTemperature.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lResponderTemperature.ForeColor = Color.Red;
            lResponderTemperature.Location = new Point(105, 180);
            lResponderTemperature.Name = "lResponderTemperature";
            lResponderTemperature.Size = new Size(73, 32);
            lResponderTemperature.TabIndex = 9;
            lResponderTemperature.Text = "00 °C";
            // 
            // lResponderTemperature_tag
            // 
            lResponderTemperature_tag.AutoSize = true;
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
            lInitatorTemperature.AutoSize = true;
            lInitatorTemperature.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lInitatorTemperature.ForeColor = Color.Red;
            lInitatorTemperature.Location = new Point(105, 110);
            lInitatorTemperature.Name = "lInitatorTemperature";
            lInitatorTemperature.Size = new Size(73, 32);
            lInitatorTemperature.TabIndex = 7;
            lInitatorTemperature.Text = "00 °C";
            // 
            // lInitiatorTemperature_tag
            // 
            lInitiatorTemperature_tag.AutoSize = true;
            lInitiatorTemperature_tag.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lInitiatorTemperature_tag.Location = new Point(3, 80);
            lInitiatorTemperature_tag.Name = "lInitiatorTemperature_tag";
            lInitiatorTemperature_tag.Size = new Size(154, 21);
            lInitiatorTemperature_tag.TabIndex = 6;
            lInitiatorTemperature_tag.Text = "Initiator temperature";
            // 
            // lCurrentQuartzDrift
            // 
            lCurrentQuartzDrift.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lCurrentQuartzDrift.AutoSize = true;
            lCurrentQuartzDrift.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lCurrentQuartzDrift.ForeColor = Color.Red;
            lCurrentQuartzDrift.Location = new Point(55, 319);
            lCurrentQuartzDrift.Name = "lCurrentQuartzDrift";
            lCurrentQuartzDrift.Size = new Size(122, 32);
            lCurrentQuartzDrift.TabIndex = 5;
            lCurrentQuartzDrift.Text = "0.00 ppm";
            // 
            // lCurrentQuartzDrift_tag
            // 
            lCurrentQuartzDrift_tag.AutoSize = true;
            lCurrentQuartzDrift_tag.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lCurrentQuartzDrift_tag.Location = new Point(3, 290);
            lCurrentQuartzDrift_tag.Name = "lCurrentQuartzDrift_tag";
            lCurrentQuartzDrift_tag.Size = new Size(147, 21);
            lCurrentQuartzDrift_tag.TabIndex = 4;
            lCurrentQuartzDrift_tag.Text = "Current quartz drift:";
            // 
            // lCompValue
            // 
            lCompValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lCompValue.AutoSize = true;
            lCompValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lCompValue.ForeColor = Color.Red;
            lCompValue.Location = new Point(55, 40);
            lCompValue.Name = "lCompValue";
            lCompValue.Size = new Size(122, 32);
            lCompValue.TabIndex = 3;
            lCompValue.Text = "0.00 ppm";
            // 
            // lCompValue_tag
            // 
            lCompValue_tag.AutoSize = true;
            lCompValue_tag.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lCompValue_tag.Location = new Point(3, 10);
            lCompValue_tag.Name = "lCompValue_tag";
            lCompValue_tag.Size = new Size(155, 21);
            lCompValue_tag.TabIndex = 2;
            lCompValue_tag.Text = "Compensation value:";
            // 
            // bCompOn
            // 
            bCompOn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bCompOn.Location = new Point(104, 446);
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
            bCompOff.Location = new Point(6, 446);
            bCompOff.Name = "bCompOff";
            bCompOff.Size = new Size(75, 40);
            bCompOff.TabIndex = 0;
            bCompOff.Text = "Turn off Comp";
            bCompOff.UseVisualStyleBackColor = true;
            bCompOff.Click += bCompOff_Click;
            // 
            // Plot
            // 
            Plot.Dock = DockStyle.Fill;
            Plot.Location = new Point(0, 24);
            Plot.Name = "Plot";
            Plot.Size = new Size(750, 490);
            Plot.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(934, 514);
            Controls.Add(Plot);
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
            pRight.PerformLayout();
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
        private ScottPlot.WinForms.FormsPlot Plot;
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
    }
}