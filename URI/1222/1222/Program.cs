using System;
using System.Collections.Generic;

namespace _1222
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> r = new List<int>();
            bool x = true;
            while (x)
            {
                string value = Console.ReadLine();
                if (string.IsNullOrEmpty(value))
                {
                    x = false;
                    break;
                }

                string[] nlc = value.Split(' ');
                int n = int.Parse(nlc[0]),
                    l = int.Parse(nlc[1]),
                    c = int.Parse(nlc[2]);

                int linhas = 0,
                    caracteres = 0;

                string[] txt = Console.ReadLine().Split(' ');

                for (int i = 0; i < txt.Length; i++)
                {
                    caracteres += txt[i].Length;

                    if (caracteres > c)
                    {
                        linhas++;
                        caracteres = txt[i].Length + 1;
                    }
                    else if (caracteres == c || caracteres + 1 == c)
                    {
                        linhas++;
                        caracteres = 0;
                    }
                    else
                    {
                        caracteres++;
                    }
                }

                if (caracteres > 0)
                {
                    linhas++;
                }

                int tl = linhas / l;

                if (linhas % l > 0)
                {
                    tl++;
                }

                r.Add(tl);
            }

            for (int i = 0; i < r.Count; i++)
            {
                Console.WriteLine(r[i]);
            }
        }
    }
}
