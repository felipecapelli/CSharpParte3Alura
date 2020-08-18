using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(2000, cpf)
        {
            Console.WriteLine("Criando Auxiliar !");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.1;
        }

        override public double GetBonificacao()
        {
            return Salario *= 0.2;
        }
    }
}
