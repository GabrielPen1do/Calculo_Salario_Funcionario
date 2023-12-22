using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_Salario_Funcionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cargo Programador = new Cargo(1, 38);
            Cargo AnalistaDeDados = new Cargo(2, 23);
            Cargo ScrumMaster = new Cargo(3, 41);

            Funcionario Carlos = new Funcionario(Programador, 'M', 168);
            Funcionario Gabriel = new Funcionario(ScrumMaster, 'M', 168);
            Funcionario Paulo = new Funcionario(AnalistaDeDados, 'M', 168);

            Console.WriteLine($"O salário final desse funcionário é: {Carlos.SalarioFinal()}");
            Console.WriteLine($"O salário final desse funcionário é: {Gabriel.SalarioFinal()}");
            Console.WriteLine($"O salário final desse funcionário é: {Paulo.SalarioFinal()}");

            Console.ReadKey();
        }
    }
}
