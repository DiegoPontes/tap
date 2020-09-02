using System;

namespace _1002
{
    class Program
    {
        const double PI = 3.14159d;
        static void Main(string[] args)
        {
            double raio = double.Parse(Console.ReadLine());
            double area = (PI * Math.Pow(raio, 2));
            Console.WriteLine($"A={area.ToString("0.0000")}");
        }
    }
}
