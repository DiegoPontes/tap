﻿using System;

namespace _1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int h, m, s, n;
            n = int.Parse(Console.ReadLine());

            h = n / 3600;
            m = (n / 60) % 60;
            s = n % 60;

            Console.WriteLine($"{h}:{m}:{s}");
        }
    }
}
