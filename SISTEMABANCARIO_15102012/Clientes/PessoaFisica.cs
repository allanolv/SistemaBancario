using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inf.EngSoftSistBancario.Modelo.Clientes
{
   public class PessoaFisica : Clientes.Cliente
    {
        public decimal Renda { get; set; }
        public int CPF { get; set; } 
    }
}
