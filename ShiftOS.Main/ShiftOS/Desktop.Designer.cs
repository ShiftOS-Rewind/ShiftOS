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
			this.listView1 = new System.Windows.Forms.ListView();
			this.taskbar = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.terminalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.textPadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.taskbarClock = new System.Windows.Forms.ToolStripLabel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.fileSkimmerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.taskbar.SuspendLayout();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.Location = new System.Drawing.Point(0, 0);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(1916, 1052);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// taskbar
			// 
			this.taskbar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.taskbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.taskbar.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.taskbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.taskbarClock});
			this.taskbar.Location = new System.Drawing.Point(0, 1020);
			this.taskbar.Name = "taskbar";
			this.taskbar.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.taskbar.Size = new System.Drawing.Size(1916, 32);
			this.taskbar.TabIndex = 1;
			this.taskbar.Text = "toolStrip1";
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.terminalToolStripMenuItem,
            this.textPadToolStripMenuItem,
            this.fileSkimmerToolStripMenuItem});
			this.toolStripDropDownButton1.Image = global::ShiftOS.Main.Properties.Resources.iconWebBrowser;
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(131, 29);
			this.toolStripDropDownButton1.Tag = ((uint)(0u));
			this.toolStripDropDownButton1.Text = "Programs";
			// 
			// terminalToolStripMenuItem
			// 
			this.terminalToolStripMenuItem.Name = "terminalToolStripMenuItem";
			this.terminalToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
			this.terminalToolStripMenuItem.Text = "Terminal";
			this.terminalToolStripMenuItem.Click += new System.EventHandler(this.terminalToolStripMenuItem_Click);
			// 
			// textPadToolStripMenuItem
			// 
			this.textPadToolStripMenuItem.Name = "textPadToolStripMenuItem";
			this.textPadToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
			this.textPadToolStripMenuItem.Text = "TextPad";
			this.textPadToolStripMenuItem.Click += new System.EventHandler(this.textPadToolStripMenuItem_Click);
			// 
			// taskbarClock
			// 
			this.taskbarClock.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.taskbarClock.Image = global::ShiftOS.Main.Properties.Resources.iconClock;
			this.taskbarClock.Name = "taskbarClock";
			this.taskbarClock.Size = new System.Drawing.Size(70, 29);
			this.taskbarClock.Tag = ((uint)(0u));
			this.taskbarClock.Text = "0:00";
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// fileSkimmerToolStripMenuItem
			// 
			this.fileSkimmerToolStripMenuItem.Name = "fileSkimmerToolStripMenuItem";
			this.fileSkimmerToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
			this.fileSkimmerToolStripMenuItem.Text = "File Skimmer";
			this.fileSkimmerToolStripMenuItem.Click += new System.EventHandler(this.fileSkimmerToolStripMenuItem_Click);
			// 
			// Desktop
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1916, 1052);
			this.Controls.Add(this.taskbar);
			this.Controls.Add(this.listView1);
			this.Name = "Desktop";
			this.Text = "Desktop";
			this.taskbar.ResumeLayout(false);
			this.taskbar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ToolStrip taskbar;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripLabel taskbarClock;
		private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem terminalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textPadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileSkimmerToolStripMenuItem;
	}
}