﻿using System;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,res=0;

            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10;i++)
            {
                res = i * n;
                Console.WriteLine(i +" x "+ n + " = " + res);
            }

        }
    }
}
