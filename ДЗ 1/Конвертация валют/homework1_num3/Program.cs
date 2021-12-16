namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double UsdToRub = 73.53;
            double UsdToTry = 14.31;
            double USD;
            Console.WriteLine("Введите сумму в USD");
            USD = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(USD + " USD в RUB " + USD * UsdToRub);
            Console.WriteLine(USD + " USD в TRY " + USD * UsdToTry);
        }
    }
}