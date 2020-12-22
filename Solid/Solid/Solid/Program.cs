using Solid._04___ISP;
using Solid._05___DIP;
using Solid._05___DIP.Contracts;
using Solid.LSP;
using Solid.OCP;
using Solid.SRP;
using Solid.SRP.Repository;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {

            #region SRP

            Fornecedor fornecedor = new Fornecedor();
            fornecedor.ChangeName("Rafael");

            FornecedorRepository rep = new FornecedorRepository();
            rep.Salvar(fornecedor);
            
            #endregion

            #region OCP

            var p = new Pessoa("Rafael", 30);
            p.ChangeName("teste");

            var pf = new PessoaFisica("Rafael", 30, "999.999.999-9");
            pf.ChangeName("Mudei o nome");

            #endregion

            #region LSP

            var veiculo = new Carro();
            veiculo.Acelerar();

            #endregion

            #region ISP

            NotaFiscal nf = new NotaFiscal();
            nf.RealizarPedido();

            #endregion

            #region DIP

            var repC = new CustomerRepository();
            var customerService = new CustomerService(repC);
            customerService.Register("Rafael");

            #endregion
        }
    }
}
