using cw2_forms.Models;

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // MessageBox.Show("zmiana");
            btnGo.Enabled = textBox1.Text.Length > 0;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            TextStatistics textStatistics = new TextStatistics(textBox1.Lines);
            lbLines.Text = textStatistics.GetLines().ToString();
            lbChars.Text = textStatistics.GetChars().ToString();
            lbLetter.Text = textStatistics.GetAlphaNum().ToString();
        }
    }
}
