﻿using System;
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
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        private ARGHEntities lol = new ARGHEntities();
        public Window5()
        {
            InitializeComponent();
            Pla.ItemsSource = lol.RATS.ToList();
        }
        private void add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                RATS c = new RATS();
                c.RatName = RatName.Text;
                c.RatAge = Convert.ToInt32(RatAge.Text);
                c.RatColor = RatColor.Text;
                c.RatType = RatType.Text;
                c.Typey_ID = 1;
                lol.RATS.Add(c);
                lol.SaveChanges();
                Pla.ItemsSource = lol.RATS.ToList();
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
                    lol.RATS.Remove(Pla.SelectedItem as RATS);
                    lol.SaveChanges();
                    Pla.ItemsSource = lol.RATS.ToList();
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

            var selected = Pla.SelectedItem as RATS;
            if (selected != null)
            {
                RatName.Text = selected.RatName;
                RatAge.Text = Convert.ToString(selected.RatAge);
                RatColor.Text = selected.RatColor;
                RatType.Text = selected.RatType;
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
                    var selected = Pla.SelectedItem as RATS;
                    selected.RatName = RatName.Text;
                    selected.RatAge = Convert.ToInt32(RatAge.Text);
                    selected.RatColor = RatColor.Text;
                    selected.RatType = RatType.Text;
                    selected.Typey_ID = 1;
                    lol.SaveChanges();
                    Pla.ItemsSource = lol.RATS.ToList();
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