using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ShiftOS.Engine;

namespace ShiftOS.Main.ShiftOS.Apps
{
    public partial class TextPad : UserControl
    {
        string editedText;
        public TextPad()
        {
            InitializeComponent();
            editedText = textBox.Text;
        }
        private bool isEdited(string editedString)
        {
            editedString = editedText;
            if(editedString != textBox.Text) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var sr = new StreamReader(openFileDialog1.FileName);
                textBox.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isEdited(textBox.Text))
            {
                MessageBox.Show("yay it works");
            }
        }
    }
}
