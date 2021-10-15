using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Plarium_Zadanie2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string selectedState;
        int i = 0;
        public MainWindow()
        {
            InitializeComponent();
            label1.Content = $"Задание 1 Написать программу, которая в цикле введет " +
                $"5 значений\n и посчитает произведение чисел, которые делятся без " +
                $"остатка на 3\n и не делятся без остатка на 5"+ 
                $"\nЗадание 2 Одноклеточная амеба каждые 3 часа делится на 2 клетки.\n" +
                $" Определить, сколько клеток будет через 3, 6, 9, ..., 24 часа,\n если первоначально была одна амеба";
        }

        private void combobox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
             selectedState = combobox1.SelectedValue.ToString();
   
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            selectedState  = combobox1.Text;

            if (selectedState == "Задание 1.1")
            {
                i = 1;

            }

            else if (selectedState == "Задание 1.2")
            {
                i = 2;

            }
            if (i == 1)
            {  
            TaskDialog task = new TaskDialog();
            task.ShowDialog();
            }
           if (i == 2)
            {
                int number = 1, real_time = 0, Time=24;
                string s = $"Вывод по заданию 1.2: в момент времени {real_time} часа имеем {number} амебы\n";
                while (real_time < Time)
                {
                    real_time += 3;
                    number *= 2;
                    s+=$"в момент времени {real_time} часа имеем {number} амебы\n";

                }
                MessageBox.Show(s);
            }
        }
    }
}
