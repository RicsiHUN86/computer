using System.Data;
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

namespace computer
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
        private void computer(object sender, RoutedEventArgs e)
        {
            listbox1.Items.Clear(); 

            string query = "SELECT Brand, Type, Display, Memory FROM Comp";
            DataTable table = Connect.GetData(query);

            foreach (DataRow row in table.Rows)
            {
                listbox1.Items.Add($"Márka: {row["Brand"]}, Típus: {row["Type"]}, Kijelző: {row["Display"]}\" , Memória: {row["Memory"]} GB");
            }
        }

        private void operaciosrendszer(object sender, RoutedEventArgs e)
        {
            listbox1.Items.Clear(); 

            string query = "SELECT Name FROM OSystem";
            DataTable table = Connect.GetData(query);

            foreach (DataRow row in table.Rows)
            {
                listbox1.Items.Add($"OS: {row["Name"]}");
            }
        }



    }
}