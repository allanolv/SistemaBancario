using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infnet.EngSoftSistBancario.Modelo;
using Infnet.EngSoftSistBancario.Repositorio;


namespace Infnet.EngSoftSistBancario.Servico
{
    public class ServicoAnaliseClientePotencial
    {
        private Cliente _cliente;
        private Double _creditoInicial;

        private void IniciaCliente(Cliente pCliente)
        {
            _cliente = pCliente;
        }

        public ServicoAnaliseClientePotencial(Cliente pCliente)
        {
            IniciaCliente(pCliente);
            _creditoInicial = 0;
        }
        public ServicoAnaliseClientePotencial(Cliente pCliente, Double pCreditoInicial)
        {
            IniciaCliente(pCliente);
            _creditoInicial = pCreditoInicial;
        }

        public ContaCorrente Avaliar()
        {
            SAvaliacaoSPC sAvaliacaoSPC = new SAvaliacaoSPC(); 
            SAvaliacaoSerasa psAvaliacaoSerasa = new SAvaliacaoSerasa();
            SAvaliacaoPerfil psAvaliacaoPerfil = new SAvaliacaoPerfil(_creditoInicial);

            sAvaliacaoSPC.Avaliar(_cliente);
            psAvaliacaoSerasa.Avaliar(_cliente);
            Double vValorPerfil = psAvaliacaoPerfil.Avaliar(_cliente);

            if (vValorPerfil == 1)
                return new ContaCorrente();
            else (vValorPerfil==2)
                return new ContaCorrenteEspecial();
        }
    }
}
