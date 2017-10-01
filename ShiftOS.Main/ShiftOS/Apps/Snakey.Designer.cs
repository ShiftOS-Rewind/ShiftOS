namespace ShiftOS.Main.ShiftOS.Apps
{
    partial class Snakey
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
            this.length = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // length
            // 
            this.length.AutoSize = true;
            this.length.BackColor = System.Drawing.Color.Transparent;
            this.length.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.length.ForeColor = System.Drawing.Color.White;
            this.length.Location = new System.Drawing.Point(573, 18);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(76, 20);
            this.length.TabIndex = 16;
            this.length.Text = "Length: 5";
            // 
            // speed
            // 
            this.speed.AutoSize = true;
            this.speed.BackColor = System.Drawing.Color.Transparent;
            this.speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.speed.ForeColor = System.Drawing.Color.White;
            this.speed.Location = new System.Drawing.Point(287, 18);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(73, 20);
            this.speed.TabIndex = 15;
            this.speed.Text = "Speed: 1";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.score.ForeColor = System.Drawing.Color.White;
            this.score.Location = new System.Drawing.Point(24, 18);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(100, 20);
            this.score.TabIndex = 14;
            this.score.Text = "Total Points: ";
            // 
            // Snakey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.length);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.score);
            this.Name = "Snakey";
            this.Size = new System.Drawing.Size(673, 447);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label length;
        internal System.Windows.Forms.Label speed;
        internal System.Windows.Forms.Label score;
    }
}
