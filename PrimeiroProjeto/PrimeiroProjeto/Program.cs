using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.ReadLine();

            /*  int b = 6;
              int h = 5;
              int B = 8;
              int area;

              area = ((b + B) / 2) * h;

              Console.WriteLine(area);
            */
            /*
          string x;
          int y;
          double z;
          char w;

          x = Console.ReadLine();
          y = int.Parse(Console.ReadLine());
          z = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
          w = char.Parse(Console.ReadLine());

          Console.WriteLine(x);
          Console.WriteLine(y);
          Console.WriteLine(z.ToString(CultureInfo.InvariantCulture));
          Console.WriteLine(w);
             */
            /*

         double largura,comprimento,vMetroQuadrado,area, precoTerreno;

         largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
         comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
         vMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

         area = largura * comprimento;
         precoTerreno = area * vMetroQuadrado; 

         Console.WriteLine( "Area: " + area.ToString("F2",CultureInfo.InvariantCulture));
         Console.WriteLine("Preço: " + precoTerreno.ToString("F2",CultureInfo.InvariantCulture));
           */


            double area, n = 3.14159, raio;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = n * (Math.Pow(raio, 2.0));

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));




            Console.ReadLine(); 

        }
    }
}
