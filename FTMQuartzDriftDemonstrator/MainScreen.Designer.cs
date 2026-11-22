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
            Plot = new ScottPlot.WinForms.FormsPlot();
            bCompOff = new Button();
            bCompOn = new Button();
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
            pRight.Controls.Add(bCompOn);
            pRight.Controls.Add(bCompOff);
            pRight.Dock = DockStyle.Right;
            pRight.Location = new Point(784, 24);
            pRight.Name = "pRight";
            pRight.Size = new Size(150, 490);
            pRight.TabIndex = 1;
            // 
            // Plot
            // 
            Plot.Dock = DockStyle.Fill;
            Plot.Location = new Point(0, 24);
            Plot.Name = "Plot";
            Plot.Size = new Size(784, 490);
            Plot.TabIndex = 2;
            // 
            // bCompOff
            // 
            bCompOff.Location = new Point(0, 446);
            bCompOff.Name = "bCompOff";
            bCompOff.Size = new Size(75, 40);
            bCompOff.TabIndex = 0;
            bCompOff.Text = "Turn off Comp";
            bCompOff.UseVisualStyleBackColor = true;
            bCompOff.Click += bCompOff_Click;
            // 
            // bCompOn
            // 
            bCompOn.Location = new Point(72, 446);
            bCompOn.Name = "bCompOn";
            bCompOn.Size = new Size(75, 40);
            bCompOn.TabIndex = 1;
            bCompOn.Text = "Turn on Comp";
            bCompOn.UseVisualStyleBackColor = true;
            bCompOn.Click += bCompOn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
    }
}