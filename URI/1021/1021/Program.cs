using System;

namespace _1021
{
    class Program
    {
        static void Main(string[] args)
        {
            double v = double.Parse(Console.ReadLine());

            double[] notasMoedas = new double[] {100, 50, 20, 10, 5, 2, 1, 0.5, 0.25, 0.1, 0.05, 0.01 };

            int nm = Convert.ToInt32(v * 100);
            string t = "nota(s)";

            Console.WriteLine("NOTAS:");
            for (int i = 0; i < 12; i++)
            {
                if(notasMoedas[i] == 1d)
                {
                    Console.WriteLine("MOEDAS:");
                    t = "moeda(s)";
                }
                int r = nm / (Convert.ToInt32(notasMoedas[i] * 100));
                nm %= Convert.ToInt32(notasMoedas[i] * 100);
                Console.WriteLine($"{r} {t} de R$ {notasMoedas[i].ToString("0.00")}");
            }
        }
    }
}
