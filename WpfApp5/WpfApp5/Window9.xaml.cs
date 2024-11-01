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
    /// Логика взаимодействия для Window9.xaml
    /// </summary>
    public partial class Window9 : Window
    {
        private ARGHEntities lol = new ARGHEntities();
        public Window9()
        {
            InitializeComponent();
            Pla.ItemsSource = lol.Workers.ToList();
        }
        private void add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Workers c = new Workers();
                c.WorkName = WorkName.Text;
                c.WorkSureName = WorkSureName.Text;
                c.WorkMiddleName = WorkMiddleName.Text;
                c.WorkMail = WorkMail.Text;
                c.WorkLivePoint_ID = 1;
                c.Points_ID = 1;
                lol.Workers.Add(c);
                lol.SaveChanges();
                Pla.ItemsSource = lol.Workers.ToList();
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
                    lol.Workers.Remove(Pla.SelectedItem as Workers);
                    lol.SaveChanges();
                    Pla.ItemsSource = lol.Workers.ToList();
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

            var selected = Pla.SelectedItem as Workers;
            if (selected != null)
            {
                WorkName.Text = selected.WorkName;
                WorkSureName.Text = selected.WorkSureName;
                WorkMiddleName.Text = selected.WorkMiddleName;
                WorkMail.Text = selected.WorkMail;
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
                    var selected = Pla.SelectedItem as Workers;
                    selected.WorkName = WorkName.Text;
                    selected.WorkSureName = WorkSureName.Text;
                    selected.WorkMiddleName = WorkMiddleName.Text;
                    selected.WorkMail = WorkMail.Text;
                    selected.WorkLivePoint_ID = 1;
                    selected.Points_ID = 1;
                    lol.SaveChanges();
                    Pla.ItemsSource = lol.Workers.ToList();
                }
                else
                {
                    MessageBox.Show("нужно что-то выбрать");
                }
            }
            catch { }
        }

        private void WorkMiddleName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }
    }
}