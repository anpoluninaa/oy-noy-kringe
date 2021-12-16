using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //СУММА И КОЛИЧЕСТВО ЧЕТНЫХ И НЕЧЕТНЫХ ЧИСЕЛ В ДИАПАЗОНЕ

            uint count_chet = 0;
            uint count_nechet = 0;
            int sum_chet = 0;
            int sum_nechet = 0;
            Console.WriteLine("Введите первое число диапозона");
            Console.WriteLine("Введите последнее число диапозона");
            int CurrentValue = Convert.ToInt32(Console.ReadLine());
            int lastValue = Convert.ToInt32(Console.ReadLine());
            
            while (CurrentValue <= lastValue)
            {
                if (CurrentValue % 2==0)
                {
                    count_chet++;
                    sum_chet = sum_chet + CurrentValue;
                }
                else
                {
                    count_nechet++;
                    sum_nechet = sum_nechet + CurrentValue;
                }
                CurrentValue++;
            }

                Console.WriteLine("Количество четных чисел: " + count_chet);
                Console.WriteLine("Количество нечетных чисел: " + count_nechet);
                Console.WriteLine("Сумма ченых чисел: " + sum_chet);
                Console.WriteLine("Сумма нечетных чисел: " + sum_nechet);
        }
    }
}