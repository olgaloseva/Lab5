using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_3
{
    class Program
    {
        //Метод упорядочивает массив из 10 случайных числе в диапазоне от -50 до 50 следующим образом:
        //первые 5 элементов по возрастанию, вторые 5 - по убыванию
        static void Main(string[] args)
        {
            const int n = 10;
            int[] arr = new int[n];
            Random rand = new Random();
            int tmp = 0;

            Console.WriteLine("Массив: ");

            for (int i = 0; i < n; i++)     //заполнение массива
            {
                arr[i] = rand.Next(-50, 50);
                Console.Write("{0},  ", arr[i]);

            }

            Console.WriteLine();
            Console.WriteLine("Результат: ");

            for (int i = 0; i < 5; i++)     //упорядочивание по возрастанию первой половины массива
            {
                for (int j = i; j < 5; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        tmp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = tmp;
                    }
                }

                Console.Write("{0}  ", arr[i]);
            }

            for (int i = 5; i < n; i++)     //упорядочивание по убыванию второй половины массива
            {
                for (int j = i; j < n; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        tmp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = tmp;
                    }
                }

                Console.Write("{0}  ", arr[i]);
            }


            Console.ReadKey();
        }
    }
}
