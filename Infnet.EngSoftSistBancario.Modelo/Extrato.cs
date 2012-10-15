using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoftSistBancario.Modelo
{
    public class Extrato : TransacaoBancaria
    {
        public Int32 QtdeDias { get; set; }

        public override bool Execute()
        {
            throw new NotImplementedException();
        }
    }
}
