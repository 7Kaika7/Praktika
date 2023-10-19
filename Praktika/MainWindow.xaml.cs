using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
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

namespace Praktika
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


        private static string connectionString = ConfigurationManager.ConnectionStrings["regBD"].ConnectionString;
        private static SqlConnection sqlConnection = null;



        private void vxod_Click(object sender, RoutedEventArgs e)
        {

            if (login_.Text != "" && parol_.Text != "")
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                string command = $"select * from [log_par]";

                SqlCommand cmd = new SqlCommand(command, sqlConnection);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    if (sqlDataReader[0].ToString() == login_.Text && sqlDataReader[1].ToString() == parol_.Text)
                    {
                        
                        Window2 с = new Window2();
                        this.Hide();
                        с.ShowDialog();
                        this.Show();
                        Close();
                    }
                
                }                       

            }
            else MessageBox.Show("Заполните поля");

        }

        private void reg_Click(object sender, RoutedEventArgs e)
        {
            Window1 a = new Window1();
            this.Hide();
            a.ShowDialog();
            this.Show();
            Close();

        }
    }
}
