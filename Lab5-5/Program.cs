using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_5
{
    class Program
    {
        //Метод, который по введенному целочисленному значению N формирует и выводит двумерный массив NxN
        //вида: 1 0 1 0 1
        //      0 1 0 1 0
        //      1 0 1 0 1
        //т.е. в нечетных строках нечетные элементы = 1, в четных строках - четные элементы = 1, остальные 0
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[n, n];

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i % 2 == 1)
                    {
                        arr[i, j] = (j % 2 == 1) ? 1 : 0;
                    }
                    else
                    {
                        arr[i, j] = (j % 2 == 0) ? 1 : 0;
                    }

                    Console.Write("{0} ", arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
