using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infnet.EngSoftSistBancario.Modelo;
using Infnet.EngSoftSistBancario.Servico.Excecoes;

namespace Infnet.EngSoftSistBancario.Servico
{
    public class SAvaliacaoPerfil : IServicoAvaliacaoPerfilPadrao
    {
        private Decimal _creditoInicial = 0;

        public SAvaliacaoPerfil(Decimal pCreditoInicial)
        {
            _creditoInicial=pCreditoInicial;
        }

        public Double Avaliar(Cliente pCliente)
        {
            Double vResult = 0;
            if (_creditoInicial < 50)
                throw new ExClienteSemPerfil("Cliente não possui perfil para abrir um conta corrente");
            else if (_creditoInicial >= 50 && _creditoInicial < 10000)
                vResult = 1; // Conta Corrente Comum;
            else if (_creditoInicial >= 10000)
                vResult = 2; // Conta Corrente Especial
            return vResult;
        }
    }
}
