using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoftSistBancario.Modelo
{
    public class PessoaJuridica : Cliente
    {
        public Cliente cliente;
        public String CNPJ { get; set; }
        public Decimal Receita { get; set; }
    }
}
