﻿using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int n;
            
            Console.WriteLine("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                i *= i;
            }

            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
