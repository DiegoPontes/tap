using System;

namespace _1013
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);
            int c = int.Parse(valores[2]);

            double ab = (a + b + Math.Abs(a - b)) / 2;
            double abc = (ab + c + Math.Abs(ab - c)) / 2;

            Console.WriteLine($"{abc} eh o maior");
        }
    }
}
