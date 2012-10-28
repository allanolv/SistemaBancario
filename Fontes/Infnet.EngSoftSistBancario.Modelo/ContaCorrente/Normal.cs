using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infnet.EngSoftSistBancario.Modelo;

namespace Infnet.EngSoftSistBancario.Modelo.ContaCorrente
{
    public class Normal : ContaCorrente
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
        public Normal() { 
        
        }

        public Normal(Cliente _nome, int _numeroDaconta, bool _statusDaConta, decimal _tarifaMensal)
        {
            this.Nome = _nome;
            this.NumeroDaconta = _numeroDaconta;
            this.StatusDaConta = _statusDaConta;
            this.Tarifa = _tarifaMensal;
        }


        public override string DescricaoDaConta()
        {
         
                return  "Informacao da Conta:" + this.Nome + this.NumeroDaconta + this.Tarifa;

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

    }
}
