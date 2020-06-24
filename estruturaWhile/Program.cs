using System;

namespace estruturaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
        

            int x = int.Parse(Console.ReadLine());
            int soma = 0;
            while (x != 0)  //Se for verdadeira entra, se for falso não entra
            {
                soma = soma + x;
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}
