﻿using System;
using System.Globalization;

namespace area
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

            string[] vet;

            vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0],CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            triangulo = (A * C) / 2;
            circulo = 3.14159 * Math.Pow(C,2);
            trapezio = ((A + B) / 2) * C;
            quadrado = Math.Pow(B, 2);
            retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
