using System;

namespace _1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            string media = ((a * 3.5 + b * 7.5) / (3.5 + 7.5)).ToString("0.00000");
            Console.WriteLine($"MEDIA = {media}");
        }
    }
}
