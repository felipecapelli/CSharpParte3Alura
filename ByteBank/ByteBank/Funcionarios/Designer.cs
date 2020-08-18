using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Designer : Funcionario
    {
        public Designer(string cpf) : base(3000, cpf)
        {
            Console.WriteLine("Criando Designer !");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.11;
        }

        override public double GetBonificacao()
        {
            return Salario *= 0.17;
        }
    }
}
