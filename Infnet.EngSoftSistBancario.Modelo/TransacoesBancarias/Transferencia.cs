using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inf.EngSoftSistBancario.Modelo.TransacoesBancarias
{
    public class Transferencia : TransacoesBancarias.TransacaoBancaria 
    {
        // Acrescentar uma propriedade acrescentado a conta corrente destino;
        public bool tipo_transferecia { get; set; }
        public Decimal Valor { get; set; }

        public override bool Execute()
        {
            throw new NotImplementedException();
        }
    }
}
