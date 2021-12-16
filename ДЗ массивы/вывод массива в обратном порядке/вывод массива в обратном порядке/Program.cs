using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int [][] arr = new int [3][];

            arr[0] = new int [3] { 1, 2, 4 }; //создаем 1-й подмассив

            arr[1] = new int [5] { 1, 2, 3, 4, 5 }; //создаем 2-й подмассив

            arr[2] = new int [8] { 1, 2, 3, 4, 5, 6, 7, 8 }; //создаем 3-й подмассив

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            
        }
    }
}