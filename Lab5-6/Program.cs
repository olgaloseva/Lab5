using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_6
{
    class Program
    {
        //Метод, который по введенному значению N формирует двумерный массив NxN, заполняет его числами вводимыми с клавиатуры и
        //проверяет, является ли матрица магческим квадратом, т.е.
        //сумма элементов в каждой строке = сумме элементов в каждом столбце = сумме элементов по каждой диагонали
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[n, n];

            Console.WriteLine();

            int[] summStr = new int[n];     //массив сумм элементов по строкам
            int[] summCol = new int[n];      //массив сумм элементов по столбцам
            int summD1 = 0, summD2 = 0;         //суммы по диагоналям

            for (int i = 0; i < n; i++)     //заполнение массива
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Введите элемент arr[{0},{1}]: ", i, j);

                    arr[i, j] = Convert.ToInt32(Console.ReadLine());

                    summStr[i] = summStr[i] + arr[i, j];

                    summCol[j] = summCol[j] + arr[i, j];

                    if (i == j)
                    {
                        summD1 = summD1 + arr[i, j];
                    }

                    if (i + j == n - 1)
                    {
                        summD2 = summD2 + arr[i, j];
                    }
                }
                Console.WriteLine();
            }

            //проверка "магичности" матрицы
            bool rez = false;
            int summ = summStr[0];

            if (summCol[0] == summ && summD1 == summ && summD2 == summ)
            {
                rez = true;

                for (int i = 0; i < n; i++)
                {
                    if (summStr[i] != summ || summCol[i] != summ)
                    {
                        rez = false;
                        break;
                    }
                }
            }

            if (rez == true)
            {
                Console.Write("Квадрат магический");
            }
            else
            {
                Console.Write("Квадрат не является магическим");
            }


            Console.ReadKey();
        }
    }
}
