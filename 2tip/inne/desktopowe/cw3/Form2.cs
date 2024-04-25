using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W: button1.Top -= 5;
                    break;
                case Keys.S:
                    button1.Top += 5;
                    break;
                case Keys.A:
                    button1.Left -= 5;
                    break;
                case Keys.D:
                    button1.Left += 5;
                    break;
            }
        }
    }
}
