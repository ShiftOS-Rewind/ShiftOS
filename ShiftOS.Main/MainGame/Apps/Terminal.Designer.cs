namespace ShiftOS.Main.ShiftOS.Apps
{
    partial class Terminal
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
            this.termmain = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // termmain
            // 
            this.termmain.BackColor = System.Drawing.Color.Black;
            this.termmain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.termmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.termmain.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termmain.ForeColor = System.Drawing.Color.White;
            this.termmain.Location = new System.Drawing.Point(0, 0);
            this.termmain.Name = "termmain";
            this.termmain.Size = new System.Drawing.Size(476, 394);
            this.termmain.TabIndex = 0;
            this.termmain.Text = "";
            this.termmain.SelectionChanged += new System.EventHandler(this.termmain_SelectionChanged);
            this.termmain.TextChanged += new System.EventHandler(this.termmain_TextChanged);
            this.termmain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.termmain_KeyDown);
            // 
            // Terminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.termmain);
            this.Name = "Terminal";
            this.Size = new System.Drawing.Size(476, 394);
            this.Load += new System.EventHandler(this.Terminal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox termmain;
    }
}
