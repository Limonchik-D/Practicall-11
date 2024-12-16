using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {/// <summary>
     /// Задача 3. Найти максимальное и минимальное значение в массиве.
     /// </summary>
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3 };

            int max = array.Max();
            int min = array.Min();
            Console.Write($"Минимальныйэлемент: {min} и максимальный элемент: {max}");
            Console.ReadKey();
        }
    }
}
