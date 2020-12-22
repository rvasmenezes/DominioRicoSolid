using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.LSP
{
    public abstract class Veiculo
    {

        public virtual void LigarMotor()
        {
            Console.WriteLine("Ligou o motor (PAI)");
        }

        public virtual void Acelerar()
        {
            Console.WriteLine("Acelerou (PAI)");
        }
    }
}
