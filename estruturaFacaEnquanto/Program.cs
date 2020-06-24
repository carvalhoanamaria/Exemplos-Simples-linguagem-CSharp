/*
  O bloco de comandos executa pelo menos uma vez, 
pois a condição é verificada no final.

verdadeira:
 */



using System;
using System.Diagnostics;
using System.Globalization;

namespace estruturaFacaEnquanto
{
    class Program
    {
        static void Main(string[] args)
        {

            double f, c;
            char resp;

            do
            {
                Console.Write("Digite a temperatura em Celsius: ");
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                f = c * 9.0 / 5.0 + 32.0;
                Console.WriteLine("Equivalente em Fahrenheit: " + f.ToString("F2", CultureInfo.InvariantCulture));
                Console.Write("Deseja repetir (s/n)?");
                resp = char.Parse(Console.ReadLine());
            } while (resp == 's'); 
                Console.ReadLine();
           
        }
    }
}
