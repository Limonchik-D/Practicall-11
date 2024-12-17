using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    internal class Program
    {/// <summary>
    /// Удаление всех чётных элементов из массива
    /// </summary>
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine($"Исходный массив: {string.Join(", ", array)}");

            int[] result = array.Where(x => x % 2 != 0).ToArray();
            Console.WriteLine($"Результат: {string.Join(", ", result)}");

            Console.ReadLine();
        }
    }
}
