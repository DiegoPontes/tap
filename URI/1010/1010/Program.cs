using System;

namespace _1010
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] p1 = Console.ReadLine().Split(' ');
            string[] p2 = Console.ReadLine().Split(' ');
            
            double resultado = (int.Parse(p1[1]) * double.Parse(p1[2])) + (int.Parse(p2[1]) * double.Parse(p2[2]));

            Console.WriteLine($"VALOR A PAGAR: R$ {resultado.ToString("0.00")}");
        }
    }
}
