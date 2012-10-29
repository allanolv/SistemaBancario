using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infnet.EngSoftSistBancario.Modelo;

namespace Infnet.EngSoftSistBancario.Modelo.ContaCorrente
{
    public class Especial : ContaCorrente
    {
        public Cliente nome;

        public Cliente Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int numeroDaconta;

        public int NumeroDaconta
        {
            get { return numeroDaconta; }
            set { numeroDaconta = value; }
        }
        public bool statusDaConta;

        public bool StatusDaConta
        {
            get { return statusDaConta; }
            set { statusDaConta = value; }
        }
        public decimal tarifaMensal;

        public decimal Tarifa
        {
            get { return tarifaMensal; }
            set { tarifaMensal = value; }
        }

        private decimal limite;

        public decimal Limite
        {
            get { return limite; }
            set { limite = value; }
        }
        public Especial()
        {

        }

        public Especial(Cliente _nome, int _numeroDaconta, bool _statusDaConta, decimal _tarifaMensal, decimal _limite)
        {
            this.Nome = _nome;
            this.NumeroDaconta = _numeroDaconta;
            this.StatusDaConta = _statusDaConta;
            this.Tarifa = _tarifaMensal;
            this.Limite = _limite;
        }


        public override string DescricaoDaConta()
        {

            return "Informacao da Conta:" + this.Nome + this.NumeroDaconta + this.Tarifa + this.Limite ;

        }


        public void setBloqueado(bool bloqueado)
        {
            this.StatusDaConta = bloqueado;
        }

        public bool getBloqueado()
        {
            return StatusDaConta;
        }

        public void Bloqueado()
        {
            setBloqueado(true);
        }

        public void Desbloqueado()
        {
            setBloqueado(false);
        }

        public bool TemLimite()
        {
            if ( Limite > 1000)
            {
                return false;
            }

            return true;
        }


    }
}
