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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        private ARGHEntities lol = new ARGHEntities();
        public Window2()
        {
            InitializeComponent();
            Pla.ItemsSource = lol.Animals.ToList();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Animals c = new Animals();
                c.WType = WType.Text;
                c.HowMuch = Convert.ToInt32(HowMuch.Text);
                lol.Animals.Add(c);
                lol.SaveChanges();
                Pla.ItemsSource = lol.CATS.ToList();
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
                    lol.Animals.Remove(Pla.SelectedItem as Animals);
                    lol.SaveChanges();
                    Pla.ItemsSource = lol.Animals.ToList();
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

            var selected = Pla.SelectedItem as Animals;
            if (selected != null)
            {
                WType.Text = selected.WType;
                HowMuch.Text = Convert.ToString(selected.HowMuch);
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
                    var selected = Pla.SelectedItem as Animals;
                    selected.WType = WType.Text;
                    selected.HowMuch = Convert.ToInt32(HowMuch.Text);
                    lol.SaveChanges();
                    Pla.ItemsSource = lol.CATS.ToList();
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

