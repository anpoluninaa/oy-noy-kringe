using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите колличество элементов массива :\t");
            int el_count = Convert.ToInt32(Console.ReadLine());
            int[] massiv = new int[el_count];

            
            for (int i = 0; i < massiv.Length; i++)
            {
                Console.Write($"Введите элемент массива с индексом {i}:\t");
                massiv[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Вывод массива:");

            for (int i = 0;i < massiv.Length;i++)
            {
                Console.WriteLine(massiv[i]);
            }
        }
    }
}