using Timer = System.Threading.Timer;

namespace Movvv
{
    public partial class Form1 : Form {
        private bool isDown = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }

        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (button2.Bottom < (this.Height-button2.Height-10)) {
                button2.Top = isDown ? button2.Top +2: button2.Top - 2;
            }
            else {
                isDown = false;
            }
        }
    }
}
