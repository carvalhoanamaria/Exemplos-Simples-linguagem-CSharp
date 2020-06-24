using System;
using System.Globalization;


namespace CaculoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            int pecaUm, pecaDois, qpecaUm, qpecaDois;
            double vpecaUm, vpecaDois, vApagar;

            string[] vet;

            vet = Console.ReadLine().Split(' ');
            pecaUm = int.Parse(vet[0]);
            qpecaUm = int.Parse(vet[1]);
            vpecaUm = double.Parse(vet[2], CultureInfo.InvariantCulture);

            vet = Console.ReadLine().Split(' ');
            pecaDois = int.Parse(vet[0]);
            qpecaDois = int.Parse(vet[1]);
            vpecaDois = double.Parse(vet[2], CultureInfo.InvariantCulture);

            vApagar = (qpecaUm * vpecaUm) + (qpecaDois * vpecaDois);

            Console.WriteLine("VALOR A PAGAR: R$ " + vApagar.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
