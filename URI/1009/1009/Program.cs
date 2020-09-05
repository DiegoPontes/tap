using System;

namespace _1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            double salario = double.Parse(Console.ReadLine());
            double vendas = double.Parse(Console.ReadLine());
            double vencimento = (salario + (vendas * 0.15));
            Console.WriteLine($"TOTAL = R$ {vencimento.ToString("0.00")}");
        }
    }
}
