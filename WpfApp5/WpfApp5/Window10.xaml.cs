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
    /// Логика взаимодействия для Window10.xaml
    /// </summary>
    public partial class Window10 : Window
    {
        private ARGHEntities lol = new ARGHEntities();
        public Window10()
        {
            InitializeComponent();
            Pla.ItemsSource = lol.FOOD.ToList();
        }
        private void add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FOOD c = new FOOD();
                c.FoodName = FoodName.Text;
                c.FoodType = FoodType.Text;
                c.HowMuch = HowMuch.Text;
                lol.FOOD.Add(c);
                lol.SaveChanges();
                Pla.ItemsSource = lol.FOOD.ToList();
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
                    lol.FOOD.Remove(Pla.SelectedItem as FOOD);
                    lol.SaveChanges();
                    Pla.ItemsSource = lol.FOOD.ToList();
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

            var selected = Pla.SelectedItem as FOOD;
            if (selected != null)
            {
                FoodName.Text = selected.FoodName;
                HowMuch.Text = Convert.ToString(selected.HowMuch);
                FoodType.Text = selected.FoodType;
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
                    var selected = Pla.SelectedItem as FOOD;
                    selected.FoodName = FoodName.Text;
                    selected.FoodType = FoodType.Text;
                    selected.HowMuch = HowMuch.Text;
                    lol.SaveChanges();
                    Pla.ItemsSource = lol.FOOD.ToList();
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