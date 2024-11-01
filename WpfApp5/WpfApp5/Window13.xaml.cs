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
    /// Логика взаимодействия для Window13.xaml
    /// </summary>
    public partial class Window13 : Window
    {
        private ARGHEntities lol = new ARGHEntities();
        public Window13()
        {
            InitializeComponent();
            Pla.ItemsSource = lol.Orders.ToList();
            Client_ID.ItemsSource = lol.CLIENTS.ToList();
            Client_ID.DisplayMemberPath = "ClientName";
            Points_ID.ItemsSource = lol.Points.ToList();
            Points_ID.DisplayMemberPath = "WLocation";
        }
        private void add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Orders c = new Orders();
                c.OrderData = Convert.ToBoolean(OrderData.Text);
                c.HowManyAnimals = Convert.ToInt32(HowManyAnimals.Text);
                c.TypeOfAnimal = TypeOfAnimal.Text;
                c.SterilizationOrCastrationNeed = SterilizationOrCastrationNeed.Text;
                c.Client_ID = Convert.ToInt32(Client_ID.SelectedIndex) + 1;
                c.Points_ID = Convert.ToInt32(Points_ID.SelectedIndex) + 1;
                lol.Orders.Add(c);
                lol.SaveChanges();
                Pla.ItemsSource = lol.Orders.ToList();
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
                    lol.Orders.Remove(Pla.SelectedItem as Orders);
                    lol.SaveChanges();
                    Pla.ItemsSource = lol.Orders.ToList();
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

            var selected = Pla.SelectedItem as Orders;
            if (selected != null)
            {
                OrderData.Text = selected.OrderData;
                HowManyAnimals.Text = Convert.ToString(selected.HowManyAnimals);
                TypeOfAnimal.Text = selected.TypeOfAnimal;
                SterilizationOrCastrationNeed.Text = selected.SterilizationOrCastrationNeed;
                Client_ID.Text = Convert.ToString(selected.Client_ID) + 1;
                Points_ID.Text = Convert.ToString(selected.Points_ID) + 1;

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
                    var selected = Pla.SelectedItem as Orders;
                    selected.OrderData = OrderData.Text;
                    selected.HowManyAnimals = Convert.ToInt32(HowManyAnimals.Text);
                    selected.TypeOfAnimal = TypeOfAnimal.Text;
                    selected.SterilizationOrCastrationNeed = SterilizationOrCastrationNeed.Text;
                    selected.Client_ID = Convert.ToInt32(Client_ID.Text) + 1;
                    selected.Points_ID = Convert.ToInt32(Points_ID.Text) + 1;
                    lol.SaveChanges();
                    Pla.ItemsSource = lol.Orders.ToList();
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