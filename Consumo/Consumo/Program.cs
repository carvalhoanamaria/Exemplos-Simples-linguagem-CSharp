using System;
using System.Globalization;

namespace Consumo
{
    class Program
    {
        static void Main(string[] args)
        {
            int X; //distância total percorrida (em Km)
            double Y,consMedio;//total de combustível gasto e consumo medio

            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            consMedio = X / Y;

            Console.WriteLine(consMedio.ToString("F3", CultureInfo.InvariantCulture) + " km/l");

        }
    }
}
