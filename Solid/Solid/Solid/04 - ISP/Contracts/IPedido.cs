using System;
using System.Collections.Generic;
using System.Text;

namespace Solid._04___ISP.Contracts
{
    public interface IPedido
    {
        DateTime Data { get; set; }

        void RealizarPedido();
    }
}
