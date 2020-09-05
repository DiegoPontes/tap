using System;

namespace _1015
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] xy1 = Console.ReadLine().Split(' ');
            string[] xy2 = Console.ReadLine().Split(' ');

            double x1 = double.Parse(xy1[0]);
            double y1 = double.Parse(xy1[1]);
            double x2 = double.Parse(xy2[0]);
            double y2 = double.Parse(xy2[1]);

            double r = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            
            Console.WriteLine(r.ToString("0.0000"));
        }
    }
}
