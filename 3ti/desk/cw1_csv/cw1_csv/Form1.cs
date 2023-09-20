using cw1_csv.Models;

namespace cw1_csv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                var result = Converter.CSVFileToList(openFileDialog1.FileName);
                if (result != null) {
                    dataGridView1.DataSource = result;
                }
                else {
                    MessageBox.Show("B³êdy format pliku CSV!!");
                }
            }
        }
    }
}