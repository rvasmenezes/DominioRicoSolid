using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.OCP
{
    public class PessoaFisica : Pessoa
    {

        public PessoaFisica(string name, int idade, string cpf) : base(name, idade)
        {
            this.Cpf = cpf;
        }

        public string Cpf { get; set; }
    }
}
