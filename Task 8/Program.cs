using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    internal class Program
    {/// <summary>
    /// Изменение размера по массиву
    /// </summary>
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            Console.WriteLine($"Исходный массив {string.Join(", ", array)}");

            Array.Resize(ref array, 6);
            Console.WriteLine($"Увеличенный массив: {string.Join(", ", array)}");

            Array.Resize(ref array, 3);
            Console.WriteLine($"Уменьшенный массив {string.Join(", ", array)}");

            Console.ReadKey();
        }
    }
}
