using System;

namespace _1047
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string[] values = n.Split(' ');

            int ht, mt, somaMin,
                hi = int.Parse(values[0]),
                mi = int.Parse(values[1]),
                hf = int.Parse(values[2]),
                mf = int.Parse(values[3]);

            somaMin = ((hf * 60) + mf) - ((hi * 60) + mi);
            
            if (somaMin <= 0)
            {
                somaMin += 24 * 60;
            }
            
            ht = somaMin / 60;
            mt = somaMin % 60;
            
            Console.WriteLine($"O JOGO DUROU {ht} HORA(S) E {mt} MINUTO(S)");
        }
    }
}
