using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inf.EngSoftSistBancario.Modelo.Banco
{
    public class ContaCorrente
    {
        public List<Normal> contaNormal { get; set; }
        public List<Especial> contaEspecial { get; set; }
        public Banco Banco
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
