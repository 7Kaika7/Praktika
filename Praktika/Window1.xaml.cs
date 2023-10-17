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

namespace Praktika
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        StreamReader reader;
        const string path = @"C:\Users\student\source\repos\21ИС-1\Praktika\Praktika\path.txt";



        private void reg_Cl(object sender, RoutedEventArgs e)
        {
            var user = new User(login.Text, parol.Text);

            if (!CheckLoginRepeat(user)) // проверка логина на повторение в файле

            {
                MessageBox.Show("Данный пользователь уже существует.");

                return;
            }
                       

            if (parol.Text != povt_parol.Text) // проверка на соответствие введенных паролей
            {
                MessageBox.Show("Пароли не совпадают. Повторите попытку.");
                return;
            }


            var writer = new StreamWriter(path, true);

            writer.WriteLine($"{user.Login} {user.Password}");

            writer.Close();

            MessageBox.Show("Вы успешно создали нового пользователя.");

        }

       

        

        private bool charVerification(object itemCharPassword, string[] symbols)
        {
            throw new NotImplementedException();
        }

        private bool CheckLoginRepeat(User user) // метод для проверки логина

        {
            reader = new StreamReader(path);
            var users = new List<User>();
            var rows = reader.ReadToEnd().Split('\n');
            rows = rows.Where(a => !string.IsNullOrEmpty(a)).ToArray();
            reader.Close();

            foreach (string row in rows)
            {
                var splitRow = row.Split(' ');

                users.Add(new User(splitRow[0], splitRow[1]));
            }

            return users.FirstOrDefault(u => u.Login == user.Login) is null;



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

