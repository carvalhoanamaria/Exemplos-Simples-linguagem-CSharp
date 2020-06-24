using System;

namespace ProdutoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            int vUm, vDois, PROD;

            vUm = int.Parse(Console.ReadLine());
            vDois = int.Parse(Console.ReadLine());

            PROD = vUm * vDois;

            Console.WriteLine("PROD = " + PROD);
            Console.ReadLine();

        }
    }
}
