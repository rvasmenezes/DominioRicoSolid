using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.LSP
{
    public class Carro : Veiculo
    {

        public override void LigarMotor()
        {
            Console.WriteLine("Ligou o motor (FILHO)");
            base.LigarMotor();
        }

        public override void Acelerar()
        {
            Console.WriteLine("Ligou o motor (FILHO)");
            base.Acelerar();
        }

    }
}
