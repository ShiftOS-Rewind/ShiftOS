﻿using System;
using System.Windows.Forms;
using ShiftOS.Engine.WindowManager;
using ShiftOS.Main.ShiftOS.Apps;

namespace ShiftOS.Main
{
    public partial class TestForm : Form
    {
        public ShiftWM shiftWM = new ShiftWM();

        public TestForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ShiftDemo demo = new ShiftDemo();
            demo.label1.Text = textBox2.Text;
            shiftWM.Init(demo, textBox1.Text, null);
            shiftWM.StartInfoboxSession(textBox1.Text, textBox2.Text, InfoboxTemplate.buttonType.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            shiftWM.Init(new Shifter(), "Shifter", Properties.Resources.iconShifter);       }
    }
}
