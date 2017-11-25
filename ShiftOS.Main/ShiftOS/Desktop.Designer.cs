namespace ShiftOS.Main.ShiftOS
{
	partial class Desktop
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
            this.components = new System.ComponentModel.Container();
            this.taskbar = new System.Windows.Forms.Panel();
            this.clockPanel = new System.Windows.Forms.Panel();
            this.lblClock = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shifterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textPadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSkimmerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.taskbar.SuspendLayout();
            this.clockPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskbar
            // 
            this.taskbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.taskbar.Controls.Add(this.clockPanel);
            this.taskbar.Controls.Add(this.panel2);
            this.taskbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.taskbar.Location = new System.Drawing.Point(0, 0);
            this.taskbar.Name = "taskbar";
            this.taskbar.Size = new System.Drawing.Size(640, 24);
            this.taskbar.TabIndex = 0;
            // 
            // clockPanel
            // 
            this.clockPanel.Controls.Add(this.lblClock);
            this.clockPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.clockPanel.Location = new System.Drawing.Point(574, 0);
            this.clockPanel.Name = "clockPanel";
            this.clockPanel.Size = new System.Drawing.Size(66, 24);
            this.clockPanel.TabIndex = 1;
            // 
            // lblClock
            // 
            this.lblClock.BackColor = System.Drawing.Color.Transparent;
            this.lblClock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblClock.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.ForeColor = System.Drawing.Color.White;
            this.lblClock.Location = new System.Drawing.Point(0, 0);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(66, 24);
            this.lblClock.TabIndex = 1;
            this.lblClock.Text = "00:00:00";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(102, 24);
            this.panel2.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(185, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "Applications";
            // 
            // applicationsToolStripMenuItem
            // 
            this.applicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shifterToolStripMenuItem,
            this.terminalToolStripMenuItem,
            this.textPadToolStripMenuItem,
            this.fileSkimmerToolStripMenuItem});
            this.applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            this.applicationsToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.applicationsToolStripMenuItem.Text = "Applications";
            // 
            // shifterToolStripMenuItem
            // 
            this.shifterToolStripMenuItem.Name = "shifterToolStripMenuItem";
            this.shifterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.shifterToolStripMenuItem.Text = "Shifter";
            this.shifterToolStripMenuItem.Click += new System.EventHandler(this.shifterToolStripMenuItem_Click);
            // 
            // terminalToolStripMenuItem
            // 
            this.terminalToolStripMenuItem.Name = "terminalToolStripMenuItem";
            this.terminalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.terminalToolStripMenuItem.Text = "Terminal";
            this.terminalToolStripMenuItem.Click += new System.EventHandler(this.terminalToolStripMenuItem_Click);
            // 
            // textPadToolStripMenuItem
            // 
            this.textPadToolStripMenuItem.Name = "textPadToolStripMenuItem";
            this.textPadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.textPadToolStripMenuItem.Text = "TextPad";
            this.textPadToolStripMenuItem.Click += new System.EventHandler(this.textPadToolStripMenuItem_Click);
            // 
            // fileSkimmerToolStripMenuItem
            // 
            this.fileSkimmerToolStripMenuItem.Name = "fileSkimmerToolStripMenuItem";
            this.fileSkimmerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fileSkimmerToolStripMenuItem.Text = "File Skimmer";
            this.fileSkimmerToolStripMenuItem.Click += new System.EventHandler(this.fileSkimmerToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Desktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.taskbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Desktop";
            this.Text = "Desktop";
            this.Load += new System.EventHandler(this.Desktop_Load);
            this.taskbar.ResumeLayout(false);
            this.clockPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Panel taskbar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel clockPanel;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shifterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textPadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileSkimmerToolStripMenuItem;
    }
}