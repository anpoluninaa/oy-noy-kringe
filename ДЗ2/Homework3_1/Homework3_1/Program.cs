using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                case 2:
                    Console.WriteLine("Вы ввели число 1 или 2");
                    break;
                default:
                    Console.WriteLine("Я не знаю, что делаать с этим числом! ");
                    break;
            }
                
        }
    }
}