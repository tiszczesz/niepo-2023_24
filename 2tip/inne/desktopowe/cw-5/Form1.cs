using cw_5.Models;

namespace cw_5
{
    public partial class Form1 : Form
    {
        private MoviesRepo _moviesRepo;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _moviesRepo = new MoviesRepo(openFileDialog1.FileName);

            }
        }
    }
}
