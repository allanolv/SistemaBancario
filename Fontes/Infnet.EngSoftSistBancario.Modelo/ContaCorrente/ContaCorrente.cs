using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoftSistBancario.Modelo
{
    public class ContaCorrente
    {
        public List<Normal> contaNormal { get; set; }
        public List<Especial> contaEspecial { get; set; }
    }
}
