using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.SRP.Repository
{
    public class FornecedorRepository : IFornecedorRepository
    {
        public void Salvar(Fornecedor fornecedor)
        {
            Console.WriteLine("Salvei");
        }
    }
}
