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

        public void random_numbers(Button name)
        {
            Random random = new Random();
            
            int n=random.Next(8);
            if (n == 1)
            {
                name.Background = Brushes.AliceBlue;
                
            }
            else if (n == 2)
            {
                name.Background = Brushes.DarkOliveGreen;
            }
            else if (n == 3)
            {
                name.Background = Brushes.Black;
            }
            else if (n == 4)
            {
                name.Background = Brushes.Crimson;
            }
            else if (n == 5)
            {
                name.Background = Brushes.Brown;
            }
            else if (n == 6)
            {
                name.Background = Brushes.Aqua;
            }
            else if (n == 7)
            {
                name.Background = Brushes.HotPink;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            random_numbers(a1);
            MessageBox.Show(" Men 1 nomreli Buttonam ");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            random_numbers(a2);
            MessageBox.Show(" Men 2 nomreli Buttonam ");
        }

        private void a3_Click(object sender, RoutedEventArgs e)
        {
            random_numbers(a3);
            MessageBox.Show(" Men 3 nomreli Buttonam ");
        }

        private void a4_Click(object sender, RoutedEventArgs e)
        {
            random_numbers(a4);
            MessageBox.Show(" Men 4 nomreli Buttonam ");
        }

        private void a5_Click(object sender, RoutedEventArgs e)
        {
            random_numbers(a5);
            MessageBox.Show(" Men 5 nomreli Buttonam ");
        }

        private void a6_Click(object sender, RoutedEventArgs e)
        {
            random_numbers(a6);
            MessageBox.Show(" Men 6 nomreli Buttonam ");
        }

        private void a1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            a1.Visibility = Visibility.Collapsed;
            Title = a1.Content.ToString();
        }

        private void a2_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            a2.Visibility = Visibility.Collapsed;
            Title = a2.Content.ToString();
        }

        private void a3_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            a3.Visibility = Visibility.Collapsed;
            Title = a3.Content.ToString();
        }

        private void a4_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            a4.Visibility = Visibility.Collapsed;
            Title = a4.Content.ToString();
        }

        private void a5_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            a5.Visibility = Visibility.Collapsed;
            Title = a5.Content.ToString();
        }

        private void a6_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            a6.Visibility = Visibility.Collapsed;
            Title = a6.Content.ToString();
        }
    }
}
