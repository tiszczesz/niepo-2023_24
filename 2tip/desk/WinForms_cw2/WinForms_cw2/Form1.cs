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
                btnInsertColor.Enabled = IsCorrectCount();
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
            btnInsertColor.Enabled = false;
        }

        private bool IsCorrectCount()
        {
            //if(listColors.Items==null) return false;
            return listColors.Items.Count > 1;
        }

        private void btnInsertColor_Click(object sender, EventArgs e)
        {
            if (listColors.SelectedItem != null) {
                MessageBox.Show("Mo¿na pracowaæ");
            }else
            {
                MessageBox.Show("Musisz wybraæ element");
            }
        }
    }
}
