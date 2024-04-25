namespace cw3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text = e.KeyData.ToString();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            label2.Text = e.KeyChar.ToString();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            label3.Text = e.KeyData.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }
    }
}
