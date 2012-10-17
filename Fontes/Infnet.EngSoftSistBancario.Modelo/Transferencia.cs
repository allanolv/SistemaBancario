using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoftSistBancario.Modelo
{
    public class Transferencia : TransacaoBancaria
    {
        // Acrescentar uma propriedade acrescentado a conta corrente destino;

        public Decimal Valor { get; set; }

        public override bool Execute()
        {
            throw new NotImplementedException();
        }
    }
}
