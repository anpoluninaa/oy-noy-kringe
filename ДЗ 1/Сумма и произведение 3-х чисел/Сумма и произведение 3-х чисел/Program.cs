using System;

namespace homework1_num2
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue, thirdValue;
            Console.WriteLine("Введите число 1 ");
            firstValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            secondValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число 3");
            thirdValue = Convert.ToDouble(Console.ReadLine());
            double result_sum = firstValue + secondValue + thirdValue;
            double result_proizved = firstValue * secondValue * thirdValue;
            Console.WriteLine("Сумма  = " + result_sum);
            Console.WriteLine("Произведения = " + result_proizved );


    }
    }
}