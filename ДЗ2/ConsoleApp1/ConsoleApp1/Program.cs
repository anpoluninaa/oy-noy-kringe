using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //пишем калькуляьтор на с#
            double FirstValue, SecondValue;
            string action;

            Console.WriteLine("Введите число 1 ");
            FirstValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            SecondValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ввыберите операцию '+', '-', '/', '*'");
            action = Console.ReadLine();
            switch (action)
            {
                
                case "+":
                    Console.WriteLine(FirstValue+SecondValue);
                    break;
                case "-":
                    Console.WriteLine(FirstValue-SecondValue) ;
                    break ;
                case "*":
                    Console.WriteLine(FirstValue * SecondValue);
                    break;
                case "/":
                    if (SecondValue ==0)
                    {
                        Console.WriteLine(0);
                    }
                    else
                    {
                        Console.WriteLine(FirstValue / SecondValue);
                    }
                    break;
                default:
                    Console.WriteLine("Ошибка.Неизвестное действие");
                    break;

            }
            Console.WriteLine();
        }
    }
}