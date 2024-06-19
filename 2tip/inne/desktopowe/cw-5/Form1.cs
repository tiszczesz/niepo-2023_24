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
                dataGridView1.DataSource = _moviesRepo.Movies;
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.ReadOnly = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Columns["Length"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            }
        }
    }
}
