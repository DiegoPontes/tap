using System;

namespace _1895
{
    class Program
    {
        static void Main(string[] args)
        {
            string ntl = Console.ReadLine();
            string[] valores = ntl.Split(' ');
            int n = int.Parse(valores[0]),
                t = int.Parse(valores[1]),
                l = int.Parse(valores[2]),
                alice = 0,
                bob = 0;

            bool vezAlice = true;

            for (int i = 1; i < n; i++)
            {
                int carta = int.Parse(Console.ReadLine());
                if (Math.Abs(t - carta) <= l)
                {
                    if (vezAlice)
                    {
                        alice += Math.Abs(t - carta);
                    }
                    else
                    {
                        bob += Math.Abs(t - carta);
                    }

                    t = carta;
                }
                vezAlice = !vezAlice;
            }

            Console.WriteLine(alice + " " + bob);
        }
    }
}
