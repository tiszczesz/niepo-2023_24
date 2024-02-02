using cw8_listBox.Models;

namespace cw8_listBox
{
    public partial class Form1 : Form
    {
        private IRepository _repository;
        public Form1()
        {
            InitializeComponent();
            _repository = new FakeRepo();
        }

        private void btnLoad_Click(object sender, EventArgs e) {
            lbProducts.DataSource = _repository.GetProducts();
        }
    }
}
