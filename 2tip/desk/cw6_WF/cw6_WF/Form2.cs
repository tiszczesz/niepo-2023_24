using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw6_WF
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            string firstname = tbFirstname.Text.Trim();
            string lastname = tbLastname.Text.Trim();
            string age = tbAge.Text.Trim();
            if (firstname.Length == 0 || lastname.Length == 0 || age.Length == 0) {
                MessageBox.Show("Błędne dane");
                return;
            }
            lbResult.Text = $"Imię: {firstname} Nazwisko: {lastname} wiek: {age} ";
        }
    }
}
