using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inf.EngSoftSistBancario.Modelo.Clientes
{
    public class PessoaJuridica:Clientes.Cliente
    {

        public String CNPJ { get; set; }
        public Decimal Receita { get; set; }
    }
}
