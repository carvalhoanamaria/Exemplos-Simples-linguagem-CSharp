using System;
using System.Globalization;

namespace SalariocomBonus
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeVend;
            double salarioFix, totalVenda, total;

            nomeVend = (Console.ReadLine());
            salarioFix = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            totalVenda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            total = (totalVenda * 0.15) + salarioFix;

            Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));


            
        }
    }
}
