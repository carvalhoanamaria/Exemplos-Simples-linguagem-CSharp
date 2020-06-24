using System;

namespace trocaDeLampada
{
    class Program
    {
        static void Main(string[] args)
        {
            char acenteu = 's';


            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Ir para o "+  i + " soquete");
                Console.WriteLine(" ");
                do
                {   
                    if (acenteu == 'n')
                    {
                        Console.WriteLine("Retirar a lâmpada.");
                        Console.WriteLine("Colocar a lâmpada nova.");
                    }
                    else
                    {
                        Console.WriteLine("Adicionar o interruptor.");
                    }
                    Console.Write("A lâmpada não acenteu? (s/n)");
                    acenteu = char.Parse(Console.ReadLine());
                } while (acenteu == 'n');

                Console.WriteLine("Pegar uma escada.");
                Console.WriteLine("Colocar a escada embaixo do soquete.");
                Console.WriteLine("Buscar uma lâmpada.");
                Console.WriteLine("Adicionar o interruptor.");
                Console.WriteLine("Subir na escada.");
                Console.WriteLine("Retirar a lâmapda queimada.");
                Console.WriteLine("Colocar a lâmpada nova.");


            }


        }
    }
}
