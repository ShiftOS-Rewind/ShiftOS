namespace ShiftOS.Main.Apps
{
    partial class Pong
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
            this.components = new System.ComponentModel.Container();
            this.playerPaddle = new System.Windows.Forms.PictureBox();
            this.cpuPaddle = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.playerPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // playerPaddle
            // 
            this.playerPaddle.BackColor = System.Drawing.Color.White;
            this.playerPaddle.Location = new System.Drawing.Point(27, 153);
            this.playerPaddle.Name = "playerPaddle";
            this.playerPaddle.Size = new System.Drawing.Size(22, 103);
            this.playerPaddle.TabIndex = 0;
            this.playerPaddle.TabStop = false;
            // 
            // cpuPaddle
            // 
            this.cpuPaddle.BackColor = System.Drawing.Color.White;
            this.cpuPaddle.Location = new System.Drawing.Point(751, 153);
            this.cpuPaddle.Name = "cpuPaddle";
            this.cpuPaddle.Size = new System.Drawing.Size(22, 103);
            this.cpuPaddle.TabIndex = 1;
            this.cpuPaddle.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.White;
            this.ball.Location = new System.Drawing.Point(390, 201);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(18, 18);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.ball);
            this.Controls.Add(this.cpuPaddle);
            this.Controls.Add(this.playerPaddle);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Pong";
            this.Size = new System.Drawing.Size(801, 470);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.playerPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox playerPaddle;
        private System.Windows.Forms.PictureBox cpuPaddle;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer gameTimer;
    }
}
