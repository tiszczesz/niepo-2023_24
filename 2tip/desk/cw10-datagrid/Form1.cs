using System.Configuration;

namespace cw10_datagrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var connString = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
        }
    }
}
