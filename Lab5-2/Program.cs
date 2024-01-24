using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2
{
    class Program
    {
        //Метод определяет сумму максимального и минимального элементов одномерного массива из 15 элементов, 
        //которые выбираются случайным образом из диапазона от 0 до 50 включительно
        static void Main(string[] args)
        {
            const int n = 15;
            int[] arr = new int[n];
            Random rand = new Random();
            arr[0] = rand.Next(0, 50);

            int max = arr[0], min = arr[0];

            Console.WriteLine("Последовательность: ");
            Console.Write("{0}  ", arr[0]);

            for (int i = 1; i < n; i++)
            {
                arr[i] = rand.Next(0, 50);
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                Console.Write("{0}  ", arr[i]);
            }
            int rez = max + min;
            Console.WriteLine();
            Console.Write("Сумма максимального и минимального элементов равна {0}", rez);
            Console.ReadKey();
        }
    }
}
