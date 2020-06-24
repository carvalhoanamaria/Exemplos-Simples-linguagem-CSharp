using System;
using System.Globalization;
namespace ValidacaodeNota
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, soma =0.00, mediaS =0.00;
            double count = 0.00;
            nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

           while (nota1 != 0 && count <= 1)
          {

       
            while ((nota1 < 0) || (nota1 > 10) )
            {
                Console.WriteLine("nota invalida");
                nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            while ((count <= 1) && ((nota1 > 0) && (nota1 <=10)) )
            {
                    // Console.WriteLine("nota valida");
                count = count + 1;
                soma = soma + nota1;
                mediaS = soma / 2;
                nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
           }

            Console.WriteLine("media = " + mediaS.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
