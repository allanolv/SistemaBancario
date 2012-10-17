using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inf.EngSoftSistBancario.Modelo.TransacoesBancarias
{
    public class Deposito : TransacoesBancarias.TransacaoBancaria
    {
        public Decimal Valor { get; set; }

        public override bool Execute()
        {
            throw new NotImplementedException();
        }
    }
}
