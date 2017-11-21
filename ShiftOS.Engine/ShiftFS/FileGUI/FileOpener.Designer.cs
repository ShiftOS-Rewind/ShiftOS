namespace ShiftOS.Engine.ShiftFS.FileGUI
{
    partial class FileOpener
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
            this.shiftButton1 = new ShiftOS.Engine.UI.ShiftButton();
            this.SuspendLayout();
            // 
            // shiftButton1
            // 
            this.shiftButton1.Location = new System.Drawing.Point(133, 66);
            this.shiftButton1.Name = "shiftButton1";
            this.shiftButton1.Size = new System.Drawing.Size(75, 22);
            this.shiftButton1.TabIndex = 0;
            // 
            // FileOpener
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.shiftButton1);
            this.Name = "FileOpener";
            this.Size = new System.Drawing.Size(368, 283);
            this.ResumeLayout(false);

        }


        #endregion

        private UI.ShiftButton shiftButton1;
    }
}
