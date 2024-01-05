using cw7_WF.Models;

namespace cw7_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGener_Click(object sender, EventArgs e)
        {
            try
            {
                int size = Convert.ToInt32(tbSize.Text);
                if (size < 2) return;
                Numbers numbers = new(size);
                //tbNumbers.Lines = Array.ConvertAll<int, string>
                //    ([.. numbers.GetNumbers], s => s.ToString());

                foreach (int num in numbers.GetNumbers)
                {
                    tbNumbers.AppendText(num + Environment.NewLine);
                }

                //MessageBox.Show(tbNumbers.Lines.Length.ToString());
                lbCount.Text = numbers.GetNumbers.Count.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Nieporawny rozmiar");
            }

        }

        
    }
}
