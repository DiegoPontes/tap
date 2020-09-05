using System;

namespace _1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int funcionario = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double valorHora = double.Parse(Console.ReadLine());
            Console.WriteLine($"NUMBER = {funcionario}");
            Console.WriteLine($"SALARY = U$ {(valorHora * horas).ToString("0.00")}");
        }
    }
}
