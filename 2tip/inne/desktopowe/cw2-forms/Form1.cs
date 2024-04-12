namespace cw2_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName != String.Empty)
                {
                    //var allText = File.ReadAllLines(openFileDialog1.FileName);
                    //textBox1.Lines = allText;
                    var allText = File.ReadAllText(openFileDialog1.FileName);
                    textBox1.Text = allText;
                }
            }
        }
    }
}
