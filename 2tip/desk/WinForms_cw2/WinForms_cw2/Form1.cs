namespace WinForms_cw2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddColor_Click(object sender, EventArgs e)
        {
            string? currentColor = cbColors.SelectedItem as string;
            if (currentColor != null)
            {
                listColors.Items.Add(currentColor);
               
                // MessageBox.Show(listColors.DataSource)
            }
            else
            {
                MessageBox.Show("Wybierz kolor!!!");
            }
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            listColors.Items.Clear();
        }

     
    }
}
