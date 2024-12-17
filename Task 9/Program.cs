using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    internal class Program
    {/// <summary>
    /// Поиск индекса элемента
    /// </summary>
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };

            int number = 4;
            int result = Array.IndexOf(array, number);
            Console.WriteLine($"Индекс элеменат {number}: {result}");

            Console.ReadKey(); 
        }
    }
}
