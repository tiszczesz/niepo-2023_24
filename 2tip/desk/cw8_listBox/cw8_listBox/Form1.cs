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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            lbProducts.DataSource = _repository.GetProducts();
        }

        private void lbProducts_DataSourceChanged(object sender, EventArgs e)
        {
            lbCoumt.Text = _repository.GetProducts().Count.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _repository.GetProducts()
                .Add(new Product{Id = 6,Name = "ssss"});
            lbProducts.DataSource = null;
            lbProducts.DataSource = _repository.GetProducts();
        }
    }
}
