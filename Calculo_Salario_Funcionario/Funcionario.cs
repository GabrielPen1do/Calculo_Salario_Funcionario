using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_Salario_Funcionario
{
    internal class Funcionario
    {
        private Cargo cargo;
        private char sexo;
        private double qtd_horas;

        public Funcionario(Cargo cargo, char sexo, double qtd_horas)
        {
            this.cargo = cargo;
            this.sexo = sexo;
            this.qtd_horas = qtd_horas;
        }


        public Cargo Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public double Qtd_horas
        {
            get { return qtd_horas; }
            set { qtd_horas = value; }
        }

        public double SalarioFinal()
        {
            return Cargo.Valor_hora * qtd_horas;
        }

    }
}
