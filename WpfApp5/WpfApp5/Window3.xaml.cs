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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        private ARGHEntities lol = new ARGHEntities();
        public Window3()
        {
            InitializeComponent();
            Pla.ItemsSource = lol.DOGS.ToList();
        }
        private void add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DOGS c = new DOGS();
                c.DogName = DogName.Text;
                c.DogAge = Convert.ToInt32(DogAge.Text);
                c.DogColor = DogColor.Text;
                c.DogType = DogType.Text;
                c.Typey_ID = 1;
                lol.DOGS.Add(c);
                lol.SaveChanges();
                Pla.ItemsSource = lol.DOGS.ToList();
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
                    lol.DOGS.Remove(Pla.SelectedItem as DOGS);
                    lol.SaveChanges();
                    Pla.ItemsSource = lol.DOGS.ToList();
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

            var selected = Pla.SelectedItem as DOGS;
            if (selected != null)
            {
                DogName.Text = selected.DogName;
                DogAge.Text = Convert.ToString(selected.DogAge);
                DogColor.Text = selected.DogColor;
                DogType.Text = selected.DogType;
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
                    var selected = Pla.SelectedItem as DOGS;
                    selected.DogName = DogName.Text;
                    selected.DogAge = Convert.ToInt32(DogAge.Text);
                    selected.DogColor = DogColor.Text;
                    selected.DogType = DogType.Text;
                    selected.Typey_ID = 1;
                    lol.SaveChanges();
                    Pla.ItemsSource = lol.DOGS.ToList();
                }
                else
                {
                    MessageBox.Show("нужно что-то выбрать");
                }
            }
            catch { }
        }

        private void DogColor_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }
    }
}