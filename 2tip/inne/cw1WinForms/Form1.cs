namespace cw1WinForms
{
    public partial class Form1 : Form
    {
        private bool isStart = false;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            timer1.Interval = 1000;
            if (!isStart)
            {
                timer1.Start();
                button1.Text = "STOP";
            }
            else
            {
                timer1.Stop();
                button1.Text = "START";
            }
            
            isStart = !isStart;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label1.Text = DateTime.Now.ToString("HH:mm:ss");
            label1.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
