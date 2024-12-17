using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Program
    {   /// <summary>
        /// Подсчёт кол-во вхождений определённого числа в массив 
        /// </summary>
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int number = 4;
            int count = array.Count(x => x == number);
            Console.WriteLine($"Кол-во вхождений в число {number}, равно {count} раз");

            Console.ReadKey();
        }
    }
}
