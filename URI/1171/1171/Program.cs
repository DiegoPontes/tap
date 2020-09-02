using System;
using System.Collections.Generic;
using System.Linq;

namespace _1171
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> valoresEntrada = new List<int>();
            List<int> valoresUnicos = new List<int>();
            
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                valoresEntrada.Add(int.Parse(Console.ReadLine()));
            }

            valoresUnicos.AddRange(valoresEntrada.OrderBy(x => x).Distinct());

            for (int i = 0; i < valoresUnicos.Count; i++)
            {
                
                Console.WriteLine($"{valoresUnicos[i]} aparece {valoresEntrada.Where(x => x == valoresUnicos[i]).Count()} vez(es)");
            }
        }
    }
}
