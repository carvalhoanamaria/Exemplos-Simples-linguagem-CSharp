﻿using System;

namespace somadeImparesConsecutivosI
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y,min,max, somaImpar= 0;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x < y)
            {
                min = x;
                max = y;
            }
            else
            {
                min = y;
                max = x;
            }
           
            for (int i = min + 1; i < max; i++)
            {
                if(i % 2 != 0)
                {
                    somaImpar = somaImpar + i;
                }
            }
            Console.WriteLine(somaImpar);
        }
    }
}
