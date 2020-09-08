using System;

namespace _2415
{
    class Program
    {
        static void Main(string[] args)
        {
            int aux = 0, c = 0;
            int n = int.Parse(Console.ReadLine());
            string[] entrada = Console.ReadLine().Split(' ');

            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(entrada[i]);
            }

            for (int i = 1; i < n; i++)
            {
                if(v[i-1] == v[i])
                {
                    aux++;
                } else
                {
                    if(aux > c)
                    {
                        c = aux;
                    }

                    aux = 0;
                }
            }
            
            if (aux > c)
            {
                c = aux;
            }
            
            if (c > 0)
            {
                c = c + 1;
            }

            Console.WriteLine(c);
        }
    }
}
