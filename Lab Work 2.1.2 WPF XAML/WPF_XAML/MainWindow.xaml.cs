using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace WPF_XAML
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataSet dataset = new DataSet();
        SqlDataAdapter Mysqlad;
        string myConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\data\Lab_1_7_3.mdf;Integrated Security=True;Connect Timeout=5";
        string usr_table = "OrderList"; 
        public MainWindow()
        {
            InitializeComponent();
            Push.Background = Brushes.LightGreen;
            try
            {
                using (SqlConnection MyConn = new SqlConnection(myConnectionString))
                {
                    Mysqlad = new SqlDataAdapter("SELECT * FROM " + usr_table, myConnectionString);
                    Mysqlad.Fill(dataset, usr_table);
                    Grid1.DataContext = dataset.Tables[usr_table];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

          private void ShowDialig(object sender, RoutedEventArgs e)
        {
            WindowNew window = new WindowNew(); 
            window.Show();
        }


        private void Save(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection MyConn = new SqlConnection(myConnectionString))
                {
                    SqlCommandBuilder builder = new SqlCommandBuilder(Mysqlad);
                    Mysqlad.UpdateCommand = builder.GetUpdateCommand();
                    int i = Mysqlad.Update(dataset.Tables[usr_table]);
                    MessageBox.Show(i.ToString() + " updated ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
