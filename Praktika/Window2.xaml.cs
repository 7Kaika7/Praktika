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
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace Praktika
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void vihod(object sender, RoutedEventArgs e)
        {
            Close();
        }

        int m; 
        int s; 
        int h;
        int i = 0;

        private void plus(object sender, RoutedEventArgs e)
        {                        
                i++;
                count.Text = Convert.ToString(i);            
        }

        private void minus(object sender, RoutedEventArgs e)
        {           
                i--;
                count.Text = Convert.ToString(i);       
        }

        private void milk(object sender, RoutedEventArgs e)
        {
            
            product.Text = Convert.ToString(ml.Header);
        }

        private void bread(object sender, RoutedEventArgs e)
        {
            
            product.Text = Convert.ToString(br.Header);
        }

        private void cheese(object sender, RoutedEventArgs e)
        {
           
            product.Text = Convert.ToString(ch.Header);
        }

        private void dobav(object sender, RoutedEventArgs e)
        {
            total.Text += $"{product.Text} x {count.Text} \n";

        }
    }
}
