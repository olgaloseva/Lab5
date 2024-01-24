using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        //Метод возвращает среднее арифметическое элементов одномерного массива из 7 элементов. Данные вводятся с клавиатуры. 
        static void Main(string[] args)
        {
            const int n = 7;
            int[] mass1 = new int[n];
            float rez = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите элемент массива: ");
                mass1[i] = Convert.ToInt32(Console.ReadLine());
                rez = rez + mass1[i];
            }
            rez = rez / 7;
            Console.WriteLine("Среднее арифметическое элементов массива: {0}", rez);
            Console.ReadKey();
        }
    }
}
