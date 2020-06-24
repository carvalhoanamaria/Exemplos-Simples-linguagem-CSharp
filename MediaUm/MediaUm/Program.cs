using System;
using System.Globalization;

namespace MediaUm
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, pesoUm = 3.5, pesoDois =7.5, media;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = ((A * pesoUm) + (B * pesoDois)) / (pesoUm + pesoDois);

            Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));
            
        }
    }
}
