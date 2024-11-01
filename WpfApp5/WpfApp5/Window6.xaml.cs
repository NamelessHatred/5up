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
    /// Логика взаимодействия для Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        private ARGHEntities lol = new ARGHEntities();
        public Window6()
        {
            InitializeComponent();
            Pla.ItemsSource = lol.TOOLS.ToList();
        }
        private void add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TOOLS c = new TOOLS();
                c.ToolName = ToolName.Text;
                c.ToolType = ToolType.Text;
                c.HowMuchTool = Convert.ToInt32(HowMuchTool.Text);
                lol.TOOLS.Add(c);
                lol.SaveChanges();
                Pla.ItemsSource = lol.TOOLS.ToList();
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
                    lol.TOOLS.Remove(Pla.SelectedItem as TOOLS);
                    lol.SaveChanges();
                    Pla.ItemsSource = lol.TOOLS.ToList();
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

            var selected = Pla.SelectedItem as TOOLS;
            if (selected != null)
            {
                ToolName.Text = selected.ToolName;
                ToolType.Text = selected.ToolType;
                HowMuchTool.Text = Convert.ToString(selected.HowMuchTool);
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
                    var selected = Pla.SelectedItem as TOOLS;
                    selected.ToolName = ToolName.Text;
                    selected.ToolType = ToolType.Text;
                    selected.HowMuchTool = Convert.ToInt32(HowMuchTool.Text);
                    lol.SaveChanges();
                    Pla.ItemsSource = lol.TOOLS.ToList();
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