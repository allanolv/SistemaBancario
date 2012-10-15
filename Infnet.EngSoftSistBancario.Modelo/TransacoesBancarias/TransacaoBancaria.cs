using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inf.EngSoftSistBancario.Modelo.TransacoesBancarias
{
    public abstract class TransacaoBancaria
    {
        // Acrescentar uma propriedade da classe de conta corrente;
        public DateTime DataEfetivacao { get; set; }

        public Comprovante Comprovante
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public abstract Boolean Execute();
    }
}
