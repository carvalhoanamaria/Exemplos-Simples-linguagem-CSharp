using System;

/* A estrutura for "para" é ótima para se fazer uma repetição baseada em uma contagem.
   Usada quando já se sabe previamente a quantidade de repetições ou um intervalo
 
   for (inicia e executa apenas na primeira vez ; condição ; incremento)
       {
       }


     for (int i =0; - < 5 ; i++){
        Console.WriteLine("Valor de i:" +i);
      }
 */


namespace estruturaFor
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, soma=0,x ;

            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                x = int.Parse(Console.ReadLine());
                soma = soma + x;
            }
            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}
