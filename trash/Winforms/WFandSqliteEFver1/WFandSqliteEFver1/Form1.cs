using WFandSqliteEFver1.Data;

namespace WFandSqliteEFver1
{
    public partial class Form1 : Form
    {
        public SqliteDbContext _db { get; set; }
        public Form1()
        {
            InitializeComponent();
            _db = new SqliteDbContext();
        }

        private void Form1_Load(object sender, EventArgs e) {
            var gifts = _db.Gifts.ToList();
            dataGridView1.DataSource = gifts;
        }
    }
}
