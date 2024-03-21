using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw1WinForms
{
    public partial class FormAdd : Form
    {
        private Form1 _form1;
        public FormAdd(Form1 form = null)
        {
            InitializeComponent();
            _form1 = form;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidationPerson())
            {
                var firstname = tbFirstname.Text.Trim();
                var lastname = tbLastname.Text.Trim();
                int age = Convert.ToInt32(tbAge.Text);
            }
            else
            {
                MessageBox.Show("Popraw dane w formularzu");
                return;
            }
            //wyciagnac z danych Persons najwieksze id osoby
            //utworzyc obiekt Person z danymi z formularza plus Id = maxId+1
            //dodac do Persons nową osobe
            //updatować liste w formularz głównym i zamknąć to okienko
        }

        private bool ValidationPerson()
        {
            return !string.IsNullOrWhiteSpace(tbFirstname.Text)
                   && !string.IsNullOrWhiteSpace(tbLastname.Text)
                   && !string.IsNullOrWhiteSpace(tbAge.Text);

        }
    }
}
