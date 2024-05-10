namespace WinForm_maj_2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e) {
            textBox1.Text += $"zdarzenie KeyDown: {e.KeyValue.ToString()}"+Environment.NewLine;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.Text += $"zdarzenie KeyPress: {e.KeyChar.ToString()}" + Environment.NewLine;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            textBox1.Text += $"zdarzenie KeyUp: {e.KeyCode.ToString()}"+Environment.NewLine;
        }
    }
}
