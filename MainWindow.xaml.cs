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
            LoadData();
            
        }
        private void LoadData()
        {
            listbox1.Items.Clear();

            var osData = Connect.GetData("SELECT * FROM OSystem");
            listbox1.Items.Add("=== Operációsrendszerek ===");
            foreach (DataRow row in osData.Rows)
            {
                listbox1.Items.Add($"{row["Id"]} - {row["Name"]}");
            }

            var compData = Connect.GetData("SELECT * FROM Comp");
            listbox1.Items.Add("=== Számítógépek ===");
            foreach (DataRow row in compData.Rows)
            {
                listbox1.Items.Add($"{row["Id"]} - {row["Brand"]} - {row["Type"]} - {row["Display"]} inch - {row["Memory"]} GB - {row["CreatedTime"]}");
            }
        }


    }
}