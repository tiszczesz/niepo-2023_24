using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_OnClick(object sender, RoutedEventArgs e) {
            label1.Content = DateTime.Now.ToShortDateString();
        }

        private void calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e) {
            var date = calendar.SelectedDate.Value;
            label2.Content = DateTime.Now.Year - date.Year;
        }

        private void button1_Click(object sender, RoutedEventArgs e) {
            new SecondWindow().ShowDialog();
        }

        private void Button2_OnClick(object sender, RoutedEventArgs e) {
            new NWDWindow().ShowDialog();
        }
    }
}