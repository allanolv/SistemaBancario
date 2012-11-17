using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infnet.EngSoftSistBancario.Modelo;

namespace Infnet.EngSoftSistBancario.Modelo
{
    public class Especial : ContaCorrente
    {
        private Decimal _limite;
        public Decimal Limite
        {
            get { return _limite; }
            set { _limite = value; }
        }

        public Especial(Cliente pCliente, String pNumeroConta, Decimal pTarifaMensal, Decimal pLimite)
        {
            _limite = pLimite;
        }
    }
}
