using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {/// <summary>
     /// Задача 4. Сортировка массива по возрастанию.
     /// </summary>
        static void Main(string[] args)
        {
            int[] array = { 9, 10, 98, 5, 6, 99, 36, 100 };
            Array.Sort(array);
            foreach (var all in array) 
            {
                Console.Write(all + " ");
            }
            Console.ReadKey();
        }
    }
}
