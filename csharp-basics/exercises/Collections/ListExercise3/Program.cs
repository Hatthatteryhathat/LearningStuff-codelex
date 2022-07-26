﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new List<string>();
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Orange");
            colors.Add("White");
            colors.Add("Black");

            Console.WriteLine("-=-=-=-=-=- Original");
            Console.WriteLine(string.Join(",", colors));

            colors.Insert(0, "Purple");

            Console.WriteLine("-=-=-=-=-=- NewList");
            Console.WriteLine(string.Join(",", colors));

            Console.ReadKey();
        }
    }
}
