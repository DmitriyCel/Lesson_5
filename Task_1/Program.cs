using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[7];
            int s = 0;
            int k = 0;
            Console.Write("Введите семь чисел:");
            for (int i = 0; i < 7; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                {
                    s += array[i];
                    k++;
                }
            }
            Console.WriteLine("{0,2:F2}", (double)s / k);

            Console.ReadKey();
        }
    }
}

