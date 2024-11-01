using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
using WpfApp5.ARGHDataSetTableAdapters;

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private ARGHEntities lol = new ARGHEntities();
        public Window1()
        {
            InitializeComponent();
            Pla.ItemsSource = lol.CATS.ToList();
        }
        private void add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CATS c = new CATS();
                c.CatName = name.Text;
                c.CatAge = Convert.ToInt32(age.Text);
                c.CatColor = color.Text;
                c.CatType = type.Text;
                c.Typey_ID = 1;
                lol.CATS.Add(c);
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
                    lol.CATS.Remove(Pla.SelectedItem as CATS);
                    lol.SaveChanges();
                    Pla.ItemsSource = lol.CATS.ToList();
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

            var selected = Pla.SelectedItem as CATS;
            if (selected != null)
            {
                name.Text = selected.CatName;
                age.Text = Convert.ToString(selected.CatAge);
                color.Text = selected.CatColor;
                type.Text = selected.CatType;
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
                    var selected = Pla.SelectedItem as CATS;
                    selected.CatName = name.Text;
                    selected.CatAge = Convert.ToInt32(age.Text);
                    selected.CatColor = color.Text;
                    selected.CatType = type.Text;
                    selected.Typey_ID = 1;
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
