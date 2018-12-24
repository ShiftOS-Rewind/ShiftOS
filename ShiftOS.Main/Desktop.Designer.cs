namespace ShiftOS.Main
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSkimmerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textPadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.breakOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shifterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationsToolStripMenuItem
            // 
            this.applicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.terminalToolStripMenuItem,
            this.fileSkimmerToolStripMenuItem,
            this.textPadToolStripMenuItem,
            this.breakOutToolStripMenuItem,
            this.shifterToolStripMenuItem});
            this.applicationsToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 9F);
            this.applicationsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            this.applicationsToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.applicationsToolStripMenuItem.Text = "Applications";
            // 
            // terminalToolStripMenuItem
            // 
            this.terminalToolStripMenuItem.Name = "terminalToolStripMenuItem";
            this.terminalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.terminalToolStripMenuItem.Text = "Terminal";
            this.terminalToolStripMenuItem.Click += new System.EventHandler(this.terminalToolStripMenuItem_Click);
            // 
            // fileSkimmerToolStripMenuItem
            // 
            this.fileSkimmerToolStripMenuItem.Name = "fileSkimmerToolStripMenuItem";
            this.fileSkimmerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fileSkimmerToolStripMenuItem.Text = "File Skimmer";
            this.fileSkimmerToolStripMenuItem.Click += new System.EventHandler(this.fileSkimmerToolStripMenuItem_Click);
            // 
            // textPadToolStripMenuItem
            // 
            this.textPadToolStripMenuItem.Name = "textPadToolStripMenuItem";
            this.textPadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.textPadToolStripMenuItem.Text = "TextPad";
            this.textPadToolStripMenuItem.Click += new System.EventHandler(this.textPadToolStripMenuItem_Click);
            // 
            // breakOutToolStripMenuItem
            // 
            this.breakOutToolStripMenuItem.Name = "breakOutToolStripMenuItem";
            this.breakOutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.breakOutToolStripMenuItem.Text = "Breakout";
            this.breakOutToolStripMenuItem.Click += new System.EventHandler(this.breakOutToolStripMenuItem_Click);
            // 
            // shifterToolStripMenuItem
            // 
            this.shifterToolStripMenuItem.Name = "shifterToolStripMenuItem";
            this.shifterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shifterToolStripMenuItem.Text = "Shifter";
            // 
            // Desktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(933, 485);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Desktop";
            this.Text = "Desktop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileSkimmerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textPadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem breakOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shifterToolStripMenuItem;
    }
}