using System;
using System.Globalization;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            int nFuncionario, horasTrab;
            double vRecebeHoras, salario;

            nFuncionario = int.Parse(Console.ReadLine());
            horasTrab = int.Parse(Console.ReadLine());
            vRecebeHoras = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            salario = vRecebeHoras * horasTrab;

            Console.WriteLine("NUMBER = " + nFuncionario);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
