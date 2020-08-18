using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando diretor !");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

        override public double GetBonificacao()
        {
            return Salario *= 0.5;
        }
    }
}
