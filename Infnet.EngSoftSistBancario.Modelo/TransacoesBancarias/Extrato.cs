using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inf.EngSoftSistBancario.Modelo.TransacoesBancarias
{
    public class Extrato : TransacoesBancarias.TransacaoBancaria
    {
        public Int32 QtdeDias { get; set; }

        public override bool Execute()
        {
            throw new NotImplementedException();
        }
    }
}