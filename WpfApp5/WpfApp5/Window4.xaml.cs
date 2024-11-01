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

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        private ARGHEntities lol = new ARGHEntities();
        public Window4()
        {
            InitializeComponent();
            Pla.ItemsSource = lol.FROGS.ToList();
        }
        private void add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FROGS c = new FROGS();
                c.FrogName = FrogName.Text;
                c.FrogAge = Convert.ToInt32(FrogAge.Text);
                c.FrogColor = FrogColor.Text;
                c.FrogType = FrogType.Text;
                c.Typey_ID = 1;
                lol.FROGS.Add(c);
                lol.SaveChanges();
                Pla.ItemsSource = lol.FROGS.ToList();
            }
            catch
            {
                MessageBox.Show("Вы что-то неправильно заполнили");
            }
        }
        private void del_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Pla.SelectedItem != null)
                {
                    lol.FROGS.Remove(Pla.SelectedItem as FROGS);
                    lol.SaveChanges();
                    Pla.ItemsSource = lol.FROGS.ToList();
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
            swagwindow swagwindow = new swagwindow();
            swagwindow.Show();
            Close();

        }
        private void Pla_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {

            var selected = Pla.SelectedItem as FROGS;
            if (selected != null)
            {
                FrogName.Text = selected.FrogName;
                FrogAge.Text = Convert.ToString(selected.FrogAge);
                FrogColor.Text = selected.FrogColor;
                FrogType.Text = selected.FrogType;
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

        private void ch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Pla.SelectedItem != null)
                {
                    var selected = Pla.SelectedItem as FROGS;
                    selected.FrogName = FrogName.Text;
                    selected.FrogAge = Convert.ToInt32(FrogAge.Text);
                    selected.FrogColor = FrogColor.Text;
                    selected.FrogType = FrogType.Text;
                    selected.Typey_ID = 1;
                    lol.SaveChanges();
                    Pla.ItemsSource = lol.FROGS.ToList();
                }
                else
                {
                    MessageBox.Show("нужно что-то выбрать");
                }
            }
            catch { }
        }

    }
}