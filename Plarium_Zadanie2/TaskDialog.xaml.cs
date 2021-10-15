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
using System.Windows.Shapes;

namespace Plarium_Zadanie2
{
    /// <summary>
    /// Логика взаимодействия для TaskDialog.xaml
    /// </summary>
    public partial class TaskDialog : Window
    {

       
        

        public TaskDialog()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            double[] Mass = textBox1.Text.Split(' ').Select(x => double.Parse(x)).ToArray();
            double  output = 1;
            bool Test = false;
        
            for (int i = 0; i < Mass.Length; i++) // проходим по массиву введенных чисел и проверяем каждое на соответствие заданным параметрам
            {
                if ((double)Mass.GetValue(i) % 3 == 0 && (double)Mass.GetValue(i) % 5 != 0)
                {
                    output *= (double)Mass.GetValue(i);
                    Test = true;
                }
            }
            if (Test) MessageBox.Show($"Вывод по заданию 1.1: произведение соответствующих чичел: {output}");
            else MessageBox.Show($"Вывод по заданию 1.1: 0");
        }
    }
}
