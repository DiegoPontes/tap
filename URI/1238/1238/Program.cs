using System;

namespace _1238
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] resultado = new string[n];
            
            for (int i = 0; i < n; i++)
            {
                string[] txt = Console.ReadLine().Split(' ');
                string txt1 = txt[0];
                string txt2 = txt[1];


                bool t1 = false,
                    t2 = false;

                string palavra = "";
                for (int x = 0; x < 50; x++)
                {
                    if (x >= txt1.Length) {
                        t1 = true;
                    }

                    if (x >= txt2.Length)
                    {
                        t2 = true;
                    }

                    if (!t1)
                    {
                        palavra += txt1[x];
                    }

                    if (!t2)
                    {
                        palavra += txt2[x];
                    }   
                    
                    if (t1 && t2) {
                        resultado[i] = palavra;
                        break;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(resultado[i]);
            }
        }
    }
}
