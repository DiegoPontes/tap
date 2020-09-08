using System;

namespace _1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());
            double l = (h * v) / 12.00f;
            Console.WriteLine(l.ToString("0.000"));
        }
    }
}
