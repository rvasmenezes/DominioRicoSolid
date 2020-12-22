using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.OCP
{
    public class Pessoa
    {

        public Pessoa(string name, int idade)
        {
            this.Name = name;
            this.Idade = idade;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Idade{ get; private set; }

        public void ChangeName(string name)
        {

            this.Name = name;
        }
    }
}
