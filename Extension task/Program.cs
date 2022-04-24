using System;

namespace Extension_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int a);
            int.TryParse(Console.ReadLine(), out int b);
            bool checkeven = a.IsEven();
            bool checkodd = b.IsOdd();
            Console.WriteLine(checkeven);
            Console.WriteLine(checkodd);
            
            
        }
    }
}
