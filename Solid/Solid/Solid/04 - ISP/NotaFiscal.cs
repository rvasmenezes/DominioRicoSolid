using Solid._04___ISP.Contracts;
using System;

namespace Solid._04___ISP
{
    public class NotaFiscal : IPedido, IEndereco
    {
        public DateTime Data { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }

        public void RealizarPedido()
        {
            throw new NotImplementedException();
        }
    }
}
