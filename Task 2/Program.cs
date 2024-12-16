using System;

namespace Task_2
{
    internal class Program
    {
        /// <summary>
        /// Задача 2. Обнулить заданный диапазон элементов в одномерном массиве.
        /// </summary>
        static void Main(string[] args)
        {
            int[] omas = Input(Size());
            Array.Clear(omas, 1, 2);
            Output(omas);
            Console.ReadKey();
        }

        static int Size()
        {
            Console.Write("Введите размер массива: ");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("Ошибка! Введите положительное число.");
            }
            return size;
        }

        static int[] Input(int size)
        {
            int[] omas = new int[size];
            for (int i = 0; i < omas.Length; i++)
            {
                Console.WriteLine($"Введите элемент {i + 1}:");
                omas[i] = int.Parse(Console.ReadLine());
            }
            return omas;
        }

        static void Output(int[] omas)
        {
            foreach (var el in omas)
            {
                Console.Write($"Элемент: {el} ");
            }
        }
    }
}
