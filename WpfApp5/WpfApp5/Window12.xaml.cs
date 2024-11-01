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
using System.Xml.Linq;

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для Window12.xaml
    /// </summary>
    public partial class Window12 : Window
    {
        private ARGHEntities lol = new ARGHEntities();
        public Window12()
        {
            InitializeComponent();
            Pla.ItemsSource = lol.BuyMoments.ToList();
            Food_ID.ItemsSource = lol.FOOD.ToList();
            Tools_ID.ItemsSource = lol.TOOLS.ToList();
            Tools_ID.DisplayMemberPath = "ToolName";
            LivePoints_ID.ItemsSource = lol.LivePointsForWorkers.ToList();
            LivePoints_ID.DisplayMemberPath = "LivePointLocation";
            Animals_ID.ItemsSource = lol.Animals.ToList();
            Animals_ID.DisplayMemberPath = "WType";
        }
        private void add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BuyMoments c = new BuyMoments();
                c.Food_ID = Convert.ToInt32(Food_ID.SelectedIndex) + 1;
                c.Tools_ID = Convert.ToInt32(Tools_ID.SelectedIndex) + 1;
                c.LivePointsForWorkers_ID = Convert.ToInt32(LivePoints_ID.SelectedIndex) + 1;
                c.Animals_ID = Convert.ToInt32(Animals_ID.SelectedIndex) + 1;
                lol.BuyMoments.Add(c);
                lol.SaveChanges();
                Pla.ItemsSource = lol.BuyMoments.ToList();
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
                    lol.BuyMoments.Remove(Pla.SelectedItem as BuyMoments);
                    lol.SaveChanges();
                    Pla.ItemsSource = lol.BuyMoments.ToList();
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

            var selected = Pla.SelectedItem as BuyMoments;
            if (selected != null)
            {
                Food_ID.Text = Convert.ToString(selected.Food_ID) + 1;
                Tools_ID.Text = Convert.ToString(selected.Tools_ID) + 1;
                LivePoints_ID.Text = Convert.ToString(selected.LivePointsForWorkers_ID) + 1;
                Animals_ID.Text = Convert.ToString(selected.Animals_ID) +1;
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
                    var selected = Pla.SelectedItem as BuyMoments;
                    selected.Food_ID = Convert.ToInt32(Food_ID.Text) + 1;
                    selected.Tools_ID = Convert.ToInt32(Tools_ID.Text) + 1;
                    selected.LivePointsForWorkers_ID = Convert.ToInt32(LivePoints_ID.Text) + 1;
                    selected.Animals_ID = Convert.ToInt32(Animals_ID.Text) + 1;
                    lol.SaveChanges();
                    Pla.ItemsSource = lol.BuyMoments.ToList();
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