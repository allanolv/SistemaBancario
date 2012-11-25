using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infnet.EngSoftSistBancario.Modelo;

namespace Infnet.EngSoftSistBancario.Modelo
{
    public class ContaCorrenteEspecial : ContaCorrente
    {
        private Decimal _limite;
        public Decimal Limite
        {
            get { return _limite; }
            set { _limite = value; }
        }

        public ContaCorrenteEspecial(Cliente pCliente, String pNumeroConta, Decimal pTarifaMensal, Decimal pLimite)
        {
            _limite = pLimite;
        }
    }
}
