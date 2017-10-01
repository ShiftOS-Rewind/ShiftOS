namespace ShiftOS.Main
{
    partial class HijackScreen
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.conversationtimer = new System.Windows.Forms.Timer();
            this.hackeffecttimer = new System.Windows.Forms.Timer();
            this.lblHijack = new System.Windows.Forms.Label();
            this.textgen = new System.Windows.Forms.Timer();
            this.lblhackwords = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // conversationtimer
            // 
            this.conversationtimer.Tick += new System.EventHandler(this.conversationtimer_Tick);
            // 
            // hackeffecttimer
            // 
            this.hackeffecttimer.Interval = 50;
            this.hackeffecttimer.Tick += new System.EventHandler(this.hackeffecttimer_Tick);
            // 
            // lblHijack
            // 
            this.lblHijack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHijack.AutoSize = true;
            this.lblHijack.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblHijack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblHijack.ForeColor = System.Drawing.Color.DimGray;
            this.lblHijack.Location = new System.Drawing.Point(143, 193);
            this.lblHijack.Name = "lblHijack";
            this.lblHijack.Size = new System.Drawing.Size(18, 25);
            this.lblHijack.TabIndex = 0;
            this.lblHijack.Text = "\\";
            // 
            // textgen
            // 
            this.textgen.Interval = 20;
            this.textgen.Tick += new System.EventHandler(this.textgen_Tick);
            // 
            // lblhackwords
            // 
            this.lblhackwords.AutoSize = true;
            this.lblhackwords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblhackwords.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhackwords.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblhackwords.Location = new System.Drawing.Point(0, 0);
            this.lblhackwords.Name = "lblhackwords";
            this.lblhackwords.Size = new System.Drawing.Size(127, 18);
            this.lblhackwords.TabIndex = 1;
            this.lblhackwords.Text = "Hijack in progress";
            // 
            // HijackScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(636, 418);
            this.Controls.Add(this.lblhackwords);
            this.Controls.Add(this.lblHijack);
            this.Name = "HijackScreen";
            this.Text = "ShiftOS";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.HijackScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer conversationtimer;
        private System.Windows.Forms.Timer hackeffecttimer;
        private System.Windows.Forms.Label lblHijack;
        private System.Windows.Forms.Timer textgen;
        private System.Windows.Forms.Label lblhackwords;
    }
}