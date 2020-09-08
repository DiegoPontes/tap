using System;
using System.Collections.Generic;

namespace _1533
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            int n = int.Parse(Console.ReadLine());
            
            while (n != 0)
            {
                if (n == 0) { break; }

                int[] s = new int[n];
                int[] aux = new int[n];

                string[] suspeitos = Console.ReadLine().Split(' ');

                for (int i = 0; i < n; i++)
                {
                    s[i] = int.Parse(suspeitos[i]);
                }

                Array.Copy(s, aux, n);
                Array.Sort(aux, 0, n);

                for (int i = 0; i < n; i++)
                {

                    if (aux[n - 2] == s[i])
                    {
                        a.Add(i + 1);
                        break;
                    }
                }

                n = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
