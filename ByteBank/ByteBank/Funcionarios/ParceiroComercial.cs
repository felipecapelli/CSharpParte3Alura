﻿using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class ParceiroComercial: IAutenticavel
    {
        public string Senha { set; get; }

        public bool Autenticar (string senha)
        {
            return Senha == senha;
        }
    }
}
