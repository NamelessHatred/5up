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
    /// Логика взаимодействия для Window11.xaml
    /// </summary>
    public partial class Window11 : Window
    {
        private ARGHEntities lol = new ARGHEntities();
        public Window11()
        {
            InitializeComponent();
            Pla.ItemsSource = lol.LivePointsForWorkers.ToList();
        }
        private void add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LivePointsForWorkers c = new LivePointsForWorkers();
                c.LivePointLocation = LivePointLocation.Text;
                c.FoodAtLeast = FoodAtLeast.Text;
                c.HowMuchComfrotable = Convert.ToInt32(HowMuchComfortable.Text);
                lol.LivePointsForWorkers.Add(c);
                lol.SaveChanges();
                Pla.ItemsSource = lol.LivePointsForWorkers.ToList();
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
                    lol.LivePointsForWorkers.Remove(Pla.SelectedItem as LivePointsForWorkers);
                    lol.SaveChanges();
                    Pla.ItemsSource = lol.LivePointsForWorkers.ToList();
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

            var selected = Pla.SelectedItem as LivePointsForWorkers;
            if (selected != null)
            {
                LivePointLocation.Text = selected.LivePointLocation;
                FoodAtLeast.Text = selected.FoodAtLeast;
                HowMuchComfortable.Text = Convert.ToString(selected.HowMuchComfrotable);
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
                    var selected = Pla.SelectedItem as LivePointsForWorkers;
                    selected.LivePointLocation = LivePointLocation.Text;
                    selected.FoodAtLeast = FoodAtLeast.Text;
                    selected.HowMuchComfrotable = Convert.ToInt32(HowMuchComfortable.Text);
                    lol.SaveChanges();
                    Pla.ItemsSource = lol.LivePointsForWorkers.ToList();
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
