﻿using System;

namespace FittBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fitt");
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FITTBUZZ");

                Console.WriteLine(i);
            }
        }
    }
}