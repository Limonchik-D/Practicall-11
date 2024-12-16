using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая__11
{
    internal class Program
    {/// <summary>
     /// Задача 1. Определить количество элементов одномерного массива.
     /// </summary>
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };

            Console.WriteLine($"Кол-во элементов массива: {array.Length}");
            Console.ReadKey();
        }
    }
}
