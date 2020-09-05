using System;
using System.Linq;

namespace _1012
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14159d;
            double[] valores = Console.ReadLine().Split(' ').Select(x => double.Parse(x)).ToArray();

            Console.WriteLine($"TRIANGULO: {((valores[0] * valores[2])/2).ToString("0.000")}");
            Console.WriteLine($"CIRCULO: {(PI * Math.Pow(valores[2], 2)).ToString("0.000")}");
            Console.WriteLine($"TRAPEZIO: {(((valores[0] + valores[1]) * valores[2]) / 2).ToString("0.000")}");
            Console.WriteLine($"QUADRADO: {Math.Pow(valores[1], 2).ToString("0.000")}");
            Console.WriteLine($"RETANGULO: {(valores[0] * valores[1]).ToString("0.000")}");
        }
    }
}
