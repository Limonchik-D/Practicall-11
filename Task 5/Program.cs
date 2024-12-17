using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {/// <summary>
    /// Реверс массива
    /// </summary>
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++) 
            {
                Console.WriteLine(array[i]);

            }

            Console.ReadKey();
        }
    }
}
