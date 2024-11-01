using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
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
    /// Логика взаимодействия для Window7.xaml
    /// </summary>
    public partial class Window7 : Window
    {
        private ARGHEntities lol = new ARGHEntities();
        public Window7()
        {
            InitializeComponent();
            Pla.ItemsSource = lol.BIRDS.ToList();
        }
        private void add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BIRDS c = new BIRDS();
                c.BirdName = BirdName.Text;
                c.BirdAge = Convert.ToInt32(BirdAge.Text);
                c.BirdColor = BirdColor.Text;
                c.BirdType = BirdType.Text;
                c.Typey_ID = 1;
                lol.BIRDS.Add(c);
                lol.SaveChanges();
                Pla.ItemsSource = lol.BIRDS.ToList();
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
                    lol.BIRDS.Remove(Pla.SelectedItem as BIRDS);
                    lol.SaveChanges();
                    Pla.ItemsSource = lol.BIRDS.ToList();
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

            var selected = Pla.SelectedItem as BIRDS;
            if (selected != null)
            {
                BirdName.Text = selected.BirdName;
                BirdAge.Text = Convert.ToString(selected.BirdAge);
                BirdColor.Text = selected.BirdColor;
                BirdType.Text = selected.BirdType;
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
                    var selected = Pla.SelectedItem as BIRDS;
                    selected.BirdName = BirdName.Text;
                    selected.BirdAge = Convert.ToInt32(BirdAge.Text);
                    selected.BirdColor = BirdColor.Text;
                    selected.BirdType = BirdType.Text;
                    selected.Typey_ID = 1;
                    lol.SaveChanges();
                    Pla.ItemsSource = lol.BIRDS.ToList();
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