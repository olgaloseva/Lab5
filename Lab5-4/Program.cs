using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_4
{
    class Program
    {
        //Метод определяет количество нечетных положительных элементов, стоящих на четных места в массиве
        //из 20 случайных чисел в диапазоне от -50 до 50.
        static void Main(string[] args)
        {
            const int n = 20;
            int[] arr = new int[n];
            Random rand = new Random();
            int kolvo = 0;

            Console.WriteLine("Массив: ");

            for (int i = 0; i < n; i++)     //заполнение массива
            {
                arr[i] = rand.Next(-50, 50);
                Console.Write("{0},  ", arr[i]);

            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 1; i < n; i = i + 2)
            {
                if (arr[i] > 0 && arr[i] % 2 == 1)
                {
                    kolvo++;
                }
            }

            Console.WriteLine("Количество нечетных положительных элементов, стоящих на четных местах равно {0}", kolvo);
            Console.ReadKey();
        }
    }
}
