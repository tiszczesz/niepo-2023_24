
using cw1WinForms.Models;

namespace cw1WinForms
{
    public partial class Form1 : Form
    {
        private bool isStart = false;
        private PersonsRepo _repo;
        public List<Person>? Persons { get; set; }
        public Form1()
        {   
            InitializeComponent();
            _repo = new PersonsRepo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            if (!isStart)
            {
                timer1.Start();
                button1.Text = "STOP";
            }
            else
            {
                timer1.Stop();
                button1.Text = "START";
            }

            isStart = !isStart;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label1.Text = DateTime.Now.ToString("HH:mm:ss");
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Persons = _repo.Persons;
            personsList.DataSource = Persons;
        }

        private void btnAddForm_Click(object sender, EventArgs e)
        {
            new FormAdd(this).ShowDialog();
        }
    }
}
