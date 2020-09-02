using System;

namespace _1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            string media = ((a * 2 + b * 3 + c * 5) / (2 + 3 + 5)).ToString("0.0");
            Console.WriteLine($"MEDIA = {media}");
        }
    }
}
