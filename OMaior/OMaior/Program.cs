﻿using System;

namespace OMaior
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C,maiorAB,maiorXC;

            string[] vet;
            vet = Console.ReadLine().Split(' ');

            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);

            maiorAB = ((A + B + Math.Abs(A - B))) / 2;
            maiorXC = (maiorAB + C + Math.Abs(maiorAB - C)) / 2;

            Console.WriteLine(maiorXC + " eh o maior");


        }
    }
}
