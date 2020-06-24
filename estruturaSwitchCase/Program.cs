using System;

namespace estruturaSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string dia;
            /*
                  if (x == 1)
                  {
                      dia = "Domingo";
                  }if (x == 2)
                  {
                      dia = "Segunda-Feira";
                  }if (x == 3)
                  {
                      dia = "Terça-Feira";
                  }if (x == 4)
                  {
                      dia = "Quarta-Feira";
                  }if (x == 5)
                  {
                      dia = "Quinta-Feira";
                  }if (x == 6)
                  {
                      dia = "Sexta-Feira";
                  }if (x == 7)
                  {
                      dia = "Sábado";
                  }
                  else
                  {
                      dia = "Valor inválido";
                  }
            */
            switch (x) {
                case 1:
                    dia = "Domingo";
                    break;
                case 2:
                    dia = "Segunda-Feira";
                    break;
                case 3:
                    dia = "Terça-Feira";
                    break;
                case 4:
                    dia = "Quarta-Feira";
                    break;
                case 5:
                    dia = "Quinta-Feira";
                    break;
                case 6:
                    dia = "Sexta-Feira";
                    break;
                case 7:
                    dia = "Sábado;";
                    break;
                default:
                    dia = "Valor inválido";
                    break;
            } 


            Console.WriteLine("Dia da semana: " + dia);
            Console.ReadLine();
        }
    }
}
