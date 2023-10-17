using System;
using System.Collections.Generic;
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
        StreamReader reader;
        const string path = @"C:\Users\student\source\repos\21ИС-1\Praktika\Praktika\path.txt";

        private bool CheckLoginRepeat(User user) // метод для проверки логина и пароля пользователя
        {
            reader = new StreamReader(path);
            var users = new List<User>();
            var rows = reader.ReadToEnd().Split('\n');
            rows = rows.Where(a => !string.IsNullOrEmpty(a)).ToArray();
            reader.Close();

            foreach (string row in rows)
            {
                var splitRow = row.Split(' ');

                users.Add(new User(splitRow[0], splitRow[1].TrimEnd('\r')));
            }

            return users.FirstOrDefault(u => u.Login == user.Login && u.Password == user.Password) is null;


        }

        private void vxod_Click(object sender, RoutedEventArgs e)
        {
            var user = new User(login_.Text, parol_.Text);

            if (CheckLoginRepeat(user))

            {
                MessageBox.Show("Неверный логин и/или пароль");
            }
            else if (!CheckLoginRepeat(user))
            {
                MessageBox.Show("Вы успешно вошли");

                Window2 c = new Window2(); // переход на третье окно
                this.Hide();
                c.ShowDialog();
                this.Show();
                Close();
            }

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
