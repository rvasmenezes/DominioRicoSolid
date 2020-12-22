using System;
using System.Collections.Generic;
using System.Text;

namespace Solid._04___ISP.Contracts
{
    public interface IEndereco
    {

        string Cidade { get; set; }
        string Estado { get; set; }
        string Pais { get; set; }

    }
}
