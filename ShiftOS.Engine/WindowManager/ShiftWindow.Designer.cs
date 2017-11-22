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
            this.leftBottomCorner = new System.Windows.Forms.Panel();
            this.rightTopCorner = new System.Windows.Forms.Panel();
            this.rightBottomCorner = new System.Windows.Forms.Panel();
            this.leftTopCorner = new System.Windows.Forms.Panel();
            this.bottomSide = new System.Windows.Forms.Panel();
            this.titleBar = new System.Windows.Forms.Panel();
            this.programIcon = new System.Windows.Forms.PictureBox();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.rightSide = new System.Windows.Forms.Panel();
            this.leftSide = new System.Windows.Forms.Panel();
            this.program.SuspendLayout();
            this.titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // program
            // 
            this.program.BackColor = System.Drawing.Color.White;
            this.program.Controls.Add(this.programContent);
            this.program.Controls.Add(this.leftBottomCorner);
            this.program.Controls.Add(this.rightTopCorner);
            this.program.Controls.Add(this.rightBottomCorner);
            this.program.Controls.Add(this.leftTopCorner);
            this.program.Controls.Add(this.bottomSide);
            this.program.Controls.Add(this.titleBar);
            this.program.Controls.Add(this.rightSide);
            this.program.Controls.Add(this.leftSide);
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
            // leftBottomCorner
            // 
            this.leftBottomCorner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.leftBottomCorner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.leftBottomCorner.Location = new System.Drawing.Point(0, 257);
            this.leftBottomCorner.Name = "leftBottomCorner";
            this.leftBottomCorner.Size = new System.Drawing.Size(5, 4);
            this.leftBottomCorner.TabIndex = 10;
            // 
            // rightTopCorner
            // 
            this.rightTopCorner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rightTopCorner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rightTopCorner.Location = new System.Drawing.Point(278, 0);
            this.rightTopCorner.Name = "rightTopCorner";
            this.rightTopCorner.Size = new System.Drawing.Size(6, 30);
            this.rightTopCorner.TabIndex = 9;
            // 
            // rightBottomCorner
            // 
            this.rightBottomCorner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rightBottomCorner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rightBottomCorner.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.rightBottomCorner.Location = new System.Drawing.Point(280, 257);
            this.rightBottomCorner.Name = "rightBottomCorner";
            this.rightBottomCorner.Size = new System.Drawing.Size(4, 4);
            this.rightBottomCorner.TabIndex = 4;
            // 
            // leftTopCorner
            // 
            this.leftTopCorner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.leftTopCorner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.leftTopCorner.Location = new System.Drawing.Point(0, 0);
            this.leftTopCorner.Name = "leftTopCorner";
            this.leftTopCorner.Size = new System.Drawing.Size(7, 30);
            this.leftTopCorner.TabIndex = 8;
            // 
            // bottomSide
            // 
            this.bottomSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bottomSide.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.bottomSide.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomSide.Location = new System.Drawing.Point(4, 257);
            this.bottomSide.Name = "bottomSide";
            this.bottomSide.Size = new System.Drawing.Size(276, 4);
            this.bottomSide.TabIndex = 3;
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.titleBar.Controls.Add(this.programIcon);
            this.titleBar.Controls.Add(this.btnMax);
            this.titleBar.Controls.Add(this.btnMin);
            this.titleBar.Controls.Add(this.Title);
            this.titleBar.Controls.Add(this.btnClose);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.titleBar.Location = new System.Drawing.Point(4, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(276, 30);
            this.titleBar.TabIndex = 0;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Programtopbar_drag);
            // 
            // programIcon
            // 
            this.programIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.programIcon.ErrorImage = null;
            this.programIcon.InitialImage = null;
            this.programIcon.Location = new System.Drawing.Point(6, 7);
            this.programIcon.Name = "programIcon";
            this.programIcon.Size = new System.Drawing.Size(16, 16);
            this.programIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.programIcon.TabIndex = 7;
            this.programIcon.TabStop = false;
            // 
            // btnMax
            // 
            this.btnMax.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMax.BackColor = System.Drawing.Color.Black;
            this.btnMax.Location = new System.Drawing.Point(230, 4);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(21, 21);
            this.btnMax.TabIndex = 6;
            this.btnMax.TabStop = false;
            this.btnMax.MouseEnter += new System.EventHandler(this.maximizebutton_MouseEnter);
            this.btnMax.MouseLeave += new System.EventHandler(this.maximizebutton_MouseLeave);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMin.BackColor = System.Drawing.Color.Black;
            this.btnMin.Location = new System.Drawing.Point(207, 4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(21, 21);
            this.btnMin.TabIndex = 5;
            this.btnMin.TabStop = false;
            this.btnMin.MouseEnter += new System.EventHandler(this.minimizebutton_MouseEnter);
            this.btnMin.MouseLeave += new System.EventHandler(this.minimizebutton_MouseLeave);
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
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(253, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 21);
            this.btnClose.TabIndex = 4;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.closebutton_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.closebutton_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.closebutton_MouseLeave);
            // 
            // rightSide
            // 
            this.rightSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rightSide.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.rightSide.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightSide.Location = new System.Drawing.Point(280, 0);
            this.rightSide.Name = "rightSide";
            this.rightSide.Size = new System.Drawing.Size(4, 261);
            this.rightSide.TabIndex = 2;
            // 
            // leftSide
            // 
            this.leftSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.leftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftSide.Location = new System.Drawing.Point(0, 0);
            this.leftSide.Name = "leftSide";
            this.leftSide.Size = new System.Drawing.Size(4, 261);
            this.leftSide.TabIndex = 1;
            // 
            // ShiftWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.program);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShiftWindow";
            this.Text = "Application Title";
            this.program.ResumeLayout(false);
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox programIcon;
        public System.Windows.Forms.Panel programContent;
        public System.Windows.Forms.Panel program;
        public System.Windows.Forms.Panel leftBottomCorner;
        public System.Windows.Forms.Panel rightTopCorner;
        public System.Windows.Forms.Panel rightBottomCorner;
        public System.Windows.Forms.Panel leftTopCorner;
        public System.Windows.Forms.Panel bottomSide;
        public System.Windows.Forms.Panel titleBar;
        public System.Windows.Forms.PictureBox btnMax;
        public System.Windows.Forms.PictureBox btnMin;
        public System.Windows.Forms.Label Title;
        public System.Windows.Forms.PictureBox btnClose;
        public System.Windows.Forms.Panel rightSide;
        public System.Windows.Forms.Panel leftSide;
    }
}
