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

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для swagwindow.xaml
    /// </summary>
    public partial class swagwindow : Window
    {
        public swagwindow()
        {
            InitializeComponent();
        }

        private void Clients_Click(object sender, RoutedEventArgs e)
        {
            FirstRoleWindow FirstRoleWindow = new FirstRoleWindow();
            FirstRoleWindow.Show();
            Close();

        }

        private void Cats_Click(object sender, RoutedEventArgs e)
        {
            Window1 Window1 = new Window1();
            Window1.Show();
            Close();
        }

        private void Animals_Click(object sender, RoutedEventArgs e)
        {
            Window2 Window2 = new Window2();
            Window2.Show();
            Close();
        }

        private void Dogs_Click(object sender, RoutedEventArgs e)
        {
            Window3 Window3 = new Window3();
            Window3.Show();
            Close();
        }

        private void Frogs_Click(object sender, RoutedEventArgs e)
        {
            Window4 Window4 = new Window4();
            Window4.Show();
            Close();
        }

        private void Rats_Click(object sender, RoutedEventArgs e)
        {
            Window5 Window5 = new Window5();
            Window5.Show();
            Close();
        }

        private void Tools_Click(object sender, RoutedEventArgs e)
        {
            Window6 Window6 = new Window6();
            Window6.Show();
            Close();
        }

        private void Birds_Click(object sender, RoutedEventArgs e)
        {
            Window7 Window7 = new Window7();
            Window7.Show();
            Close();
        }

        private void Points_Click(object sender, RoutedEventArgs e)
        {
            Window8 Window8 = new Window8();
            Window8.Show();
            Close();
        }

        private void Workers_Click(object sender, RoutedEventArgs e)
        {
            Window9 Window9 = new Window9();
            Window9.Show();
            Close();
        }

        private void Food_Click(object sender, RoutedEventArgs e)
        {
            Window10 Window10 = new Window10();
            Window10.Show();
            Close();
        }

        private void LivePointsForWorkers_Click(object sender, RoutedEventArgs e)
        {
            Window11 Window11 = new Window11();
            Window11.Show();
            Close();
        }

        private void BuyMoments_Click(object sender, RoutedEventArgs e)
        {
            Window12 Window12 = new Window12();
            Window12.Show();
            Close();
        }

        private void Orders_Click(object sender, RoutedEventArgs e)
        {
            Window13 Window13 = new Window13();
            Window13.Show();
            Close();
        }
    }
}
