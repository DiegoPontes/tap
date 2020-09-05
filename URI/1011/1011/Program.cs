using System;

namespace _1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double resultado = (4 / 3.0d) * 3.14159d * Math.Pow(r, 3);

            Console.WriteLine($"VOLUME = {resultado.ToString("0.000")}");
        }
    }
}
