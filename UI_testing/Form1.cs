using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_testing
{
    public partial class Form1 : Form
    {
        private int _FrameIndex;
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonClickMeClick(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello World!");
            //ButtonTimer.Enabled = true;
            ButtonTimer.Enabled =
                !ButtonTimer.Enabled;

        }

        private void ButtonTimer_Tick(object sender, EventArgs e)
        {
            button1.Left+= 8;
            if (button1.Left > Width)
                button1.Left = -99;
            _FrameIndex++;
            Text = "Frame #" + _FrameIndex;
        }
        
    }
}
