using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    internal class Program
    {/// <summary>  
    /// Поиск элемента по условию
    /// </summary>
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };

            int result = array.FirstOrDefault(x => x > 4);

            if (result != 0)
            {
                Console.WriteLine($"Элемент больше четырёх: {result}");
            }
            else 
            {
                Console.WriteLine("Ошибка");
            }

            Console.ReadKey();


        }
    }
}
