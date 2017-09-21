namespace HijackScreen
{
    partial class Form1
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
            this.lblHijack = new System.Windows.Forms.Label();
            this.conversationTimer = new System.Windows.Forms.Timer(this.components);
            this.textGen = new System.Windows.Forms.Timer(this.components);
            this.lblhackwords = new System.Windows.Forms.Label();
            this.tmrHackFX = new System.Windows.Forms.Timer(this.components);
            this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lblHijack
            // 
            this.lblHijack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHijack.AutoSize = true;
            this.lblHijack.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblHijack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHijack.Location = new System.Drawing.Point(151, 173);
            this.lblHijack.Name = "lblHijack";
            this.lblHijack.Size = new System.Drawing.Size(18, 25);
            this.lblHijack.TabIndex = 2;
            this.lblHijack.Text = "\\";
            // 
            // conversationTimer
            // 
            this.conversationTimer.Tick += new System.EventHandler(this.conversationTimer_Tick);
            // 
            // textGen
            // 
            this.textGen.Interval = 20;
            this.textGen.Tick += new System.EventHandler(this.textGen_Tick);
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
            this.lblhackwords.TabIndex = 3;
            this.lblhackwords.Text = "Encrypting MBR...";
            // 
            // tmrHackFX
            // 
            this.tmrHackFX.Interval = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(653, 457);
            this.Controls.Add(this.lblHijack);
            this.Controls.Add(this.lblhackwords);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblHijack;
        internal System.Windows.Forms.Timer conversationTimer;
        internal System.Windows.Forms.Timer textGen;
        internal System.Windows.Forms.Label lblhackwords;
        internal System.Windows.Forms.Timer tmrHackFX;
        internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
    }
}

