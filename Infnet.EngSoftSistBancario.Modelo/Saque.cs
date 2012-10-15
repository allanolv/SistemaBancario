using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoftSistBancario.Modelo
{
    public class Saque : TransacaoBancaria
    {
        public Decimal Valor { get; set; }

        public override bool Execute()
        {
            throw new NotImplementedException();
        }
    }
}
