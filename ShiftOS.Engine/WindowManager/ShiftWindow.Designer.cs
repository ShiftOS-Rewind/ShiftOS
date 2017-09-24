namespace ShiftOS.Engine.WindowManager
{
    partial class ShiftWindow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.program = new System.Windows.Forms.Panel();
            this.programContent = new System.Windows.Forms.Panel();
            this.bottomleftcorner = new System.Windows.Forms.Panel();
            this.toprightcorner = new System.Windows.Forms.Panel();
            this.bottomrightcorner = new System.Windows.Forms.Panel();
            this.topleftcorner = new System.Windows.Forms.Panel();
            this.bottom = new System.Windows.Forms.Panel();
            this.top = new System.Windows.Forms.Panel();
            this.programIcon = new System.Windows.Forms.PictureBox();
            this.maximizebutton = new System.Windows.Forms.PictureBox();
            this.minimizebutton = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.closebutton = new System.Windows.Forms.PictureBox();
            this.right = new System.Windows.Forms.Panel();
            this.left = new System.Windows.Forms.Panel();
            this.program.SuspendLayout();
            this.top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizebutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizebutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closebutton)).BeginInit();
            this.SuspendLayout();
            // 
            // program
            // 
            this.program.BackColor = System.Drawing.Color.White;
            this.program.Controls.Add(this.programContent);
            this.program.Controls.Add(this.bottomleftcorner);
            this.program.Controls.Add(this.toprightcorner);
            this.program.Controls.Add(this.bottomrightcorner);
            this.program.Controls.Add(this.topleftcorner);
            this.program.Controls.Add(this.bottom);
            this.program.Controls.Add(this.top);
            this.program.Controls.Add(this.right);
            this.program.Controls.Add(this.left);
            this.program.Dock = System.Windows.Forms.DockStyle.Fill;
            this.program.Location = new System.Drawing.Point(0, 0);
            this.program.Name = "program";
            this.program.Size = new System.Drawing.Size(284, 261);
            this.program.TabIndex = 11;
            // 
            // programContent
            // 
            this.programContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.programContent.Location = new System.Drawing.Point(4, 30);
            this.programContent.Name = "programContent";
            this.programContent.Size = new System.Drawing.Size(276, 227);
            this.programContent.TabIndex = 11;
            // 
            // bottomleftcorner
            // 
            this.bottomleftcorner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bottomleftcorner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bottomleftcorner.Location = new System.Drawing.Point(0, 257);
            this.bottomleftcorner.Name = "bottomleftcorner";
            this.bottomleftcorner.Size = new System.Drawing.Size(5, 4);
            this.bottomleftcorner.TabIndex = 10;
            // 
            // toprightcorner
            // 
            this.toprightcorner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toprightcorner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toprightcorner.Location = new System.Drawing.Point(278, 0);
            this.toprightcorner.Name = "toprightcorner";
            this.toprightcorner.Size = new System.Drawing.Size(6, 30);
            this.toprightcorner.TabIndex = 9;
            // 
            // bottomrightcorner
            // 
            this.bottomrightcorner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomrightcorner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bottomrightcorner.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.bottomrightcorner.Location = new System.Drawing.Point(280, 257);
            this.bottomrightcorner.Name = "bottomrightcorner";
            this.bottomrightcorner.Size = new System.Drawing.Size(4, 4);
            this.bottomrightcorner.TabIndex = 4;
            // 
            // topleftcorner
            // 
            this.topleftcorner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.topleftcorner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.topleftcorner.Location = new System.Drawing.Point(0, 0);
            this.topleftcorner.Name = "topleftcorner";
            this.topleftcorner.Size = new System.Drawing.Size(7, 30);
            this.topleftcorner.TabIndex = 8;
            // 
            // bottom
            // 
            this.bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bottom.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom.Location = new System.Drawing.Point(4, 257);
            this.bottom.Name = "bottom";
            this.bottom.Size = new System.Drawing.Size(276, 4);
            this.bottom.TabIndex = 3;
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.top.Controls.Add(this.programIcon);
            this.top.Controls.Add(this.maximizebutton);
            this.top.Controls.Add(this.minimizebutton);
            this.top.Controls.Add(this.Title);
            this.top.Controls.Add(this.closebutton);
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.ForeColor = System.Drawing.SystemColors.ControlText;
            this.top.Location = new System.Drawing.Point(4, 0);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(276, 30);
            this.top.TabIndex = 0;
            this.top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Programtopbar_drag);
            // 
            // programIcon
            // 
            this.programIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.programIcon.ErrorImage = null;
            this.programIcon.InitialImage = null;
            this.programIcon.Location = new System.Drawing.Point(6, 7);
            this.programIcon.Name = "programIcon";
            this.programIcon.Size = new System.Drawing.Size(16, 16);
            this.programIcon.TabIndex = 7;
            this.programIcon.TabStop = false;
            // 
            // maximizebutton
            // 
            this.maximizebutton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.maximizebutton.BackColor = System.Drawing.Color.Black;
            this.maximizebutton.Location = new System.Drawing.Point(228, 5);
            this.maximizebutton.Name = "maximizebutton";
            this.maximizebutton.Size = new System.Drawing.Size(21, 21);
            this.maximizebutton.TabIndex = 6;
            this.maximizebutton.TabStop = false;
            // 
            // minimizebutton
            // 
            this.minimizebutton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.minimizebutton.BackColor = System.Drawing.Color.Black;
            this.minimizebutton.Location = new System.Drawing.Point(205, 5);
            this.minimizebutton.Name = "minimizebutton";
            this.minimizebutton.Size = new System.Drawing.Size(21, 21);
            this.minimizebutton.TabIndex = 5;
            this.minimizebutton.TabStop = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(25, 8);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(98, 13);
            this.Title.TabIndex = 3;
            this.Title.Text = "Application Title";
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Programtopbar_drag);
            // 
            // closebutton
            // 
            this.closebutton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.closebutton.BackColor = System.Drawing.Color.Black;
            this.closebutton.Location = new System.Drawing.Point(251, 5);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(21, 21);
            this.closebutton.TabIndex = 4;
            this.closebutton.TabStop = false;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // right
            // 
            this.right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.right.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.right.Dock = System.Windows.Forms.DockStyle.Right;
            this.right.Location = new System.Drawing.Point(280, 0);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(4, 261);
            this.right.TabIndex = 2;
            // 
            // left
            // 
            this.left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.left.Dock = System.Windows.Forms.DockStyle.Left;
            this.left.Location = new System.Drawing.Point(0, 0);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(4, 261);
            this.left.TabIndex = 1;
            // 
            // ShiftWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.program);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShiftWindow";
            this.program.ResumeLayout(false);
            this.top.ResumeLayout(false);
            this.top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizebutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizebutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closebutton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel program;
        internal System.Windows.Forms.Panel bottomleftcorner;
        internal System.Windows.Forms.Panel toprightcorner;
        internal System.Windows.Forms.Panel bottomrightcorner;
        internal System.Windows.Forms.Panel topleftcorner;
        internal System.Windows.Forms.Panel bottom;
        internal System.Windows.Forms.Panel top;
        public System.Windows.Forms.PictureBox programIcon;
        internal System.Windows.Forms.PictureBox maximizebutton;
        internal System.Windows.Forms.PictureBox minimizebutton;
        internal System.Windows.Forms.Label Title;
        internal System.Windows.Forms.PictureBox closebutton;
        internal System.Windows.Forms.Panel right;
        internal System.Windows.Forms.Panel left;
        public System.Windows.Forms.Panel programContent;
    }
}
