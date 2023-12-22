using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_Salario_Funcionario
{
    internal class Cargo
    {
        private int cod_cargo;
        private double valor_hora;

        public Cargo(int cod_cargo, double valor_hora)
        {
            this.cod_cargo = cod_cargo;
            this.valor_hora = valor_hora;
        }

        public int Cod_cargo
        {
            get { return cod_cargo; }
            set { cod_cargo = value; }
        }

        public double Valor_hora
        {
            get { return valor_hora; }
            set { valor_hora = value; }
        }

    }
}
