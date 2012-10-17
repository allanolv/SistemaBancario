using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inf.EngSoftSistBancario.Modelo.TransacoesBancarias
{
    public class Comprovante
    {
        public Decimal Valor { get; set; }

        public TransacaoBancaria TransacaoBancaria
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void Emitir()
        {
            throw new NotImplementedException();
        }
    }
}
