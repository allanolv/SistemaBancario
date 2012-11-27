using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infnet.EngSoftSistBancario.Modelo.Excecoes;

namespace Infnet.EngSoftSistBancario.Modelo
{
    public class ContaCorrente
    {
        // Atributos privados;
        private Cliente _titular;
        private StatusContaCorrente _status;
        private Decimal _saldo;

        // Atributos publicos;
        public Cliente Titular
        {
            get { return _titular; }
            set { _titular = value; }
        }
        
        public String Agencia { get; set; }
        public String Numero { get; set; }

        public StatusContaCorrente Status
        {
            get { return _status; }
        }
        
        public Decimal Tarifa { get; set; }

        public Decimal Saldo
        {
            get { return _saldo; }
        }
        
        // Métodos
        public ContaCorrente()
        {

        }

        public ContaCorrente(Cliente pCliente, String pNumeroConta, Decimal pTarifaMensal)
        {
            this.Titular = pCliente;
            this.Numero = pNumeroConta;
            this.Tarifa = pTarifaMensal;
            _status = StatusContaCorrente.Ativa;
        }
        public void Encerrar()
        {
            _status = StatusContaCorrente.Encerrada;
        }
        public void Bloquear()
        {
            _status = StatusContaCorrente.Bloqueada;
        }

        public void Desbloquear()
        {
            _status = StatusContaCorrente.Ativa;
        }

        public virtual void Creditar(Decimal pValor)
        {
            _saldo += pValor;
        }

        public virtual void Debitar(Decimal pValor)
        {
            if ((_saldo - pValor) < 0)
                throw new ExSaldoInsuficiente("Saldo insuficiente");
        }

    }
}
