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
    /// 

    class Program
    {
        //Написать программу,  которая в цикле введет 5 значений и посчитает произведение чисел, которые делятся без остатка на 3 и не делятся без остатка на 5
        //задание 1.1
      static void task1_1()
        {
            Array Mass = Array.CreateInstance(typeof(double), 5); //в данном массиве будут храниться введенные значения
            double input, output = 1;
            bool Test = false;
            Console.WriteLine("Введите 5 чисел");
            for (int i = 0; i < Mass.Length; i++)
            {
                while (!double.TryParse(Console.ReadLine(), out input)) //цыкл ввода, если пользователь вводит не число то выдаст предупреждение
                {
                    Console.WriteLine("Ошибка ввода! Введите число");
                }
                Mass.SetValue(input, i);
            }
            for (int i = 0; i < Mass.Length; i++) // проходим по массиву введенных чисел и проверяем каждое на соответствие заданным параметрам
            {
                if ((double)Mass.GetValue(i) % 3 == 0 && (double)Mass.GetValue(i) % 5 != 0)
                {
                    output *= (double)Mass.GetValue(i);
                    Test = true;
                }
            }
            if (Test) Console.WriteLine($"Вывод по заданию 1.1: произведение соответствующих чичел: {output}");
            else Console.WriteLine($"Вывод по заданию 1.1: 0"); // если ниодно число не соответствовало заданным параметрам
        }
        //Одноклеточная амеба каждые 3 часа делится на 2 клетки. Определить, сколько клеток будет через 3, 6, 9, ..., 24 часа, если первоначально была одна амеба.
        //задание1.2
        //задание на геометрическую прогрессию решается циклом а в метод мы передаем период который мы хотим наблюдать
        static void task1_2(int Time)
        {
            int number = 1, real_time = 0;
            Console.WriteLine($"Вывод по заданию 1.2: в момент времени {real_time} часа имеем {number} амебы");
            while (real_time < Time)
            {
                real_time += 3;
                number *= 2;
                Console.WriteLine($"в момент времени {real_time} часа имеем {number} амебы");

            }

        }


        //задание 2.1
        /*В некоторой стране используются денежные купюры достоинством  в 1, 2, 4, 8, 16, 32 и 64. Дано натуральное число п.
     * Как наименьшим количеством таких денежных купюр можно выплатить сумму п (указать количество каждой из используемых для выплаты купюр)?
     * Предполагается, что имеется достаточно большое количество купюр всех достоинств*/
        // для решения достаточно до максимума заполнять купюрами максимально возможного номинала а затем понижать номинал, решается цыклом и получением остатка от деления

        static void task2_1()
        {
            int input, nominal = 64, output;
            Console.WriteLine("Введите числo");
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Ошибка ввода! Введите число");
            }
            Console.WriteLine($"Вывод по заданию 2.1:");
            while (input > 0)
            {
                output = input / nominal;
                Console.WriteLine($"купюр номиналом {nominal} небходмо {output} штук");
                input %= nominal;
                nominal /= 2;
            }
        }
        //задание 2.2
        /*Дано натуральное число. Верно ли, что цифра а встречается в нем более k раз?*/
        static void task2_2()
        {
            int input, k, output, a;
            Console.WriteLine("Введите проверяемое числo");
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Ошибка ввода! Введите число");
            }

            Console.WriteLine("Введите числo a");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Ошибка ввода! Введите число");
            }

            Console.WriteLine("Введите числo k");
            while (!int.TryParse(Console.ReadLine(), out k))
            {
                Console.WriteLine("Ошибка ввода! Введите число");//выше были цыклы ввода и проверки введенного значения для необходимых цыфр 
            }

            while (input > 0)//при помощи остатка от деления на 10 получаем последнию цифру а делением на 10 понижаем разрядность, аналогично будем делать и в следующих заданиях
            {
                output = input % 10;
                if (output == a) k--;//если встретили искомое число то понижаем к на 1, если по итогу оно меньше 0 то утверждение истинно 
                input /= 10;
            }
            if (k < 0) Console.WriteLine($"утверждение истино");
            else Console.WriteLine($"утверждение ложно");

        }
        //задание 2.3
        /*Дано натуральное число. Определить, верно ли, что сумма его цифр больше т, 
         * а само число заканчивается на y?*/
        static void task2_3()
        {
            int input, t, output = 0, y;
            Console.WriteLine("Введите проверяемое числo");
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Ошибка ввода! Введите число");
            }

            Console.WriteLine("Введите числo t");
            while (!int.TryParse(Console.ReadLine(), out t))
            {
                Console.WriteLine("Ошибка ввода! Введите число");
            }

            Console.WriteLine("Введите числo y");
            while (!int.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Ошибка ввода! Введите число");
            }

            if (input % 10 == y)
            {//если последняя цифра не равна искомой то смысла в подчете суммы нет и цыкл не будет запускаться так как утверждение уже ложно
                while (input > 0)
                {

                    output += input % 10;
                    input /= 10;
                }
                if (output > t) Console.WriteLine($"утверждение истино");
                else Console.WriteLine($"утверждение ложно");
            }
            else Console.WriteLine($"утверждение ложно");
        }
        //задание 2.4
        /*Дано натуральное число, в котором все цифры различны.
         * Определить, какая цифра расположена в нем левее: максимальная или минимальная. */
        static void task2_4()
        {
            int input, min = 9, max = 0, output;
            bool Test = true;//если истина то максимальное левее, иначе минимальная
            Console.WriteLine("Введите проверяемое числo");
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Ошибка ввода! Введите число");
            }

            while (input > 0)
            {
                output = input % 10;
                if (output > max)
                {
                    max = output;
                    Test = true;
                }
                if (output < min)
                {
                    min = output;
                    Test = false;
                }
                input /= 10;
            }
            if (Test) Console.WriteLine($"максимальная цифра левее");
            else Console.WriteLine($"минимальная цифра левее");
        }

    
    }

}