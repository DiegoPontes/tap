using System;

namespace _1014
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            
            Console.WriteLine($"{(x / y).ToString("0.000")} km/l");
        }
    }
}
