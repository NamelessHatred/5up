using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для FirstRoleWindow.xaml
    /// </summary>
    public partial class FirstRoleWindow : Window
    {
        private ARGHEntities lol = new ARGHEntities();
        public FirstRoleWindow()
        {
            InitializeComponent();
            Pla.ItemsSource = lol.CLIENTS.ToList();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CLIENTS c = new CLIENTS();
                c.ClientName = ClientName.Text;
                c.ClientSureName = ClientSureName.Text;
                c.ClientFather = ClientFather.Text;
                c.ClientMail = ClientMail.Text;
                c.ClientBuyNumber = Convert.ToInt32(BuyNumber.Text);
                lol.CLIENTS.Add(c);
                lol.SaveChanges();
                Pla.ItemsSource = lol.CLIENTS.ToList();
            }
            catch
            {
                MessageBox.Show("Вы что-то неправильно заполнили");
            }
        }

        private void ch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Pla.SelectedItem != null)
                {
                    var selected = Pla.SelectedItem as CLIENTS;
                    selected.ClientName = ClientName.Text;
                    selected.ClientSureName = ClientSureName.Text;
                    selected.ClientFather = ClientFather.Text;
                    selected.ClientMail = ClientMail.Text;
                    selected.ClientBuyNumber = Convert.ToInt32(BuyNumber.Text);
                    lol.SaveChanges();
                    Pla.ItemsSource = lol.CLIENTS.ToList();
                }
                else
                {
                    MessageBox.Show("нужно что-то выбрать");
                }
            }
            catch { MessageBox.Show("Вы что-то неправильно заполнили"); }
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Pla.SelectedItem != null)
                {
                    lol.CLIENTS.Remove(Pla.SelectedItem as CLIENTS);
                    lol.SaveChanges();
                    Pla.ItemsSource = lol.CLIENTS.ToList();
                }
                else
                {
                    MessageBox.Show("нужно что-то выбрать");
                }

            }
            catch
            {
                MessageBox.Show("Нельзя удалить, так как есть связь с другой таблицей");
            }
        }
        private void oleg_Click(object sender, RoutedEventArgs e)
        {
            Window1 Window1 = new Window1();
            Window1.Show();
            Close();

        }
        private void Pla_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {

            var selected = Pla.SelectedItem as CLIENTS;
            if (selected != null)
            {

                name.Text = selected.CNAME;
                sure.Text = selected.CSURENAMENAME;
                nick.Text = selected.CMIDDLENAME;
                age.Text = Convert.ToString(selected.AGE);
                email.Text = selected.EMAIL;
            }
        }
        private void name_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Zа-яА-Я]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void age_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
