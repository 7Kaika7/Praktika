using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Praktika
{   

    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["regBD"].ConnectionString;
        private static SqlConnection sqlConnection = null;

        public Window1()
        {
            InitializeComponent();
            
        }


        

        private void reg_Cl(object sender, RoutedEventArgs e)
        {

                       

            if (parol.Text != povt_parol.Text) // проверка на соответствие введенных паролей
            {
                MessageBox.Show("Пароли не совпадают. Повторите попытку.");
                return;
            }            

            sqlConnection = new SqlConnection(connectionString);
            

            SqlCommand command = new SqlCommand("INSERT INTO log_par (login, parol) VALUES (@log, @par)", sqlConnection);

            command.Parameters.AddWithValue("@log", login.Text);
            command.Parameters.AddWithValue("@par", parol.Text);

            sqlConnection.Open();
            command.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Вы успешно создали нового пользователя.");

        }

       

        private void vxod_Cl(object sender, RoutedEventArgs e)
        {
            MainWindow b = new MainWindow();
            this.Hide();
            b.ShowDialog();
            this.Show();
            Close();

        }
    }
    }

