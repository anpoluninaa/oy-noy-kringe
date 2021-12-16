using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишите программу, которая проверяет число, введенное с клавиатуры на четность 
            double chislo;
            Console.WriteLine("Введите число");
            chislo = Convert.ToDouble(Console.ReadLine());
            if (chislo % 2 == 0)
            {
                Console.WriteLine("Число четное");

            }
            else
            {
                Console.WriteLine("Число нечетное");
            }
           
        }
    }
}
