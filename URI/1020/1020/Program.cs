using System;

namespace _1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int dias = int.Parse(Console.ReadLine());
            int a = dias / 365;
            int m = (dias % 365) / 30;
            int d = ((dias % 365) % 30);
            
            Console.WriteLine($"{a} ano(s)");
            Console.WriteLine($"{m} mes(es)");
            Console.WriteLine($"{d} dia(s)");
        }
    }
}
