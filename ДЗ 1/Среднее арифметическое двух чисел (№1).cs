using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace youtube_lesson1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //Напишите программу, вычисляющую среднее арифметическое двух чисел

            double firstValue, secondValue;

            Console.WriteLine("Введите число 1");

            firstValue = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число 2");
            secondValue = Convert.ToDouble(Console.ReadLine());

            double result = (firstValue + secondValue) / 2;
            Console.WriteLine("Среднее арифметическое = " + result);
        }
    }   



}
