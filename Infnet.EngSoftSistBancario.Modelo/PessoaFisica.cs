using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoftSistBancario.Modelo
{
    public class PessoaFisica : Cliente 
    {
        public decimal Renda { get; set; }
        public int CPF { get; set; } 
    }
}
