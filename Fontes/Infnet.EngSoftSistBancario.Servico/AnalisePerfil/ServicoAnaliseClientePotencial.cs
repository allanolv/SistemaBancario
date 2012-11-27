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
        private String _agencia;
        public ServicoAnaliseClientePotencial(String pAgencia)
        {
            _agencia = pAgencia;
        }

        public void Avaliar(Cliente pCliente,  Decimal pTarifaMensal, Decimal pLimiteCredito, Decimal pCreditoInicial)
        {
            ContaCorrente _contaCorrente = null;
            ContaCorrenteEspecial _contaCorrenteEspecial = null;
            SAvaliacaoSPC sAvaliacaoSPC = new SAvaliacaoSPC(); 
            SAvaliacaoSerasa sAvaliacaoSerasa = new SAvaliacaoSerasa();
            SAvaliacaoPerfil sAvaliacaoPerfil = new SAvaliacaoPerfil(pCreditoInicial);
            RepositorioContaCorrente rRepositorioContaCorrente = RepositorioContaCorrente.Instancia();
            

            sAvaliacaoSPC.Avaliar(pCliente);
            sAvaliacaoSerasa.Avaliar(pCliente);
            Double vValorPerfil = sAvaliacaoPerfil.Avaliar(pCliente);


            if (vValorPerfil == 1)
            {
                _contaCorrente = rRepositorioContaCorrente.CriarContaCorrente(pCliente, _agencia, pTarifaMensal);
                _contaCorrente.Creditar(pCreditoInicial);
                rRepositorioContaCorrente.Alterar<ContaCorrente>(_contaCorrente);
            }
            else if (vValorPerfil == 2)
            {
                _contaCorrenteEspecial = rRepositorioContaCorrente.CriarContaCorrente(pCliente, _agencia, pTarifaMensal, pLimiteCredito);
                _contaCorrenteEspecial.Creditar(pCreditoInicial);
                rRepositorioContaCorrente.Alterar<ContaCorrenteEspecial>(_contaCorrenteEspecial);
            }
        }
    }
}
