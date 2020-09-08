using System;
using System.Collections.Generic;
using System.Linq;

namespace _1089
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> picos = new List<int>();

            while (n != 0)
            {
                int p = 0;
                int[] a = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

                if (((a[0] - a[n-1]) * (a[0]-a[1])) > 0)
                {
                    p++;
                }

                if ((a[n-1] - a[n-2]) * (a[n-1] - a[0]) > 0)
                {
                    p++;
                }
                
                for (int i = 1; i < n - 1; i++)
                {
                    if ((a[i] - a[i - 1]) * (a[i] - a[i + 1]) > 0)
                    {
                        p++;
                    }
                }

                picos.Add(p);
                n = int.Parse(Console.ReadLine());
            }

            foreach (var p in picos)
            {
                Console.WriteLine(p);
            }
        }
    }
}
