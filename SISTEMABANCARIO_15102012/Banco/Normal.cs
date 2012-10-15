using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inf.EngSoftSistBancario.Modelo.Banco
{
    public class Normal : ContaCorrente  
    {
        public int agencia { get; set; }
        public int numeroDaConta { get; set; }
        public decimal tarifaMensal { get; set; }
        public int debitoBancario { get; set; }
      

    }
}
