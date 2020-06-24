using System;
using System.Globalization;

namespace estruturaWhile2
{
    class Program
    {
        static void Main(string[] args)
        {
            double mediaIdade, idade, soma = 0;
            int cont = 0;

            idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while ( idade > 0) //True se a idade for maior que zero.
            {
                cont = cont + 1;
                soma = soma + idade;
              
                idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             }
            mediaIdade = soma / cont;
            Console.WriteLine(mediaIdade.ToString("F2", CultureInfo.InvariantCulture));
          
            Console.ReadLine();
        }
    }
}
