using System;
using System.Globalization;

namespace MediaDois
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, pesoUm = 2, pesoDois = 3, pesoTres = 5, media;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = ((A * pesoUm) + (B * pesoDois) + (C * pesoTres)) / (pesoUm + pesoDois + pesoTres);

            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
