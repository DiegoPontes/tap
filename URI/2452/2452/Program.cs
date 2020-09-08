using System;
using System.Collections.Generic;

namespace _2452
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cp = Console.ReadLine().Split(' ');
            string[] pi = Console.ReadLine().Split(' ');

            int c = int.Parse(cp[0]),
                p = int.Parse(cp[1]),
                v = -1,
                rep = 0;

            Queue<int> posicoes = new Queue<int>();

            bool[] fila = new bool[c + 2];

            for (int i = 0; i < p; i++)
            {
                posicoes.Enqueue(int.Parse(pi[i]));
            }

            while (posicoes.Count > 0)
            {
                rep++;

                int x = posicoes.Peek();
                posicoes.Dequeue();

                fila[x] = true;
                if (!fila[x - 1] && x - 1 > 0)
                {
                    posicoes.Enqueue(x - 1);
                    fila[x - 1] = true;
                }

                if (!fila[x + 1] && x + 1 <= c)
                {
                    posicoes.Enqueue(x + 1);
                    fila[x + 1] = true;
                }

                if (rep == p)
                {
                    p = posicoes.Count;
                    v++;
                    rep = 0;
                }
            }
            Console.WriteLine(v);
        }
    }
}
