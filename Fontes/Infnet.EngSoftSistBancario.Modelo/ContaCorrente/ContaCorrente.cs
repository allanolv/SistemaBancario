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
        public String Agencia { get; set; }
        public String Numero { get; set; }
        public Decimal Tarifa { get; set; }
        public Cliente Titular
        {
            get { return _titular; }
            set { _titular = value; }
        }
        public StatusContaCorrente Status
        {
            get { return _status; }
        }
        public Decimal Saldo
        {
            get { return _saldo; }
        }
        
        // Métodos
        public ContaCorrente() 
        { 
            /// Refatorar esse método, pois eu não consegui criar a classe de forma que a mesma não tivesse um método construtor sem parâmetro.
            if (_titular == null || Numero == String.Empty || Tarifa <= 0)
                throw new Exception("Não possível criar uma conta corrente sem que o titular, número da conta ou tarifa");
        }

        public ContaCorrente(Cliente pCliente, String pAgencia, String pNumeroConta, Decimal pTarifaMensal)
        {
            this.Titular = pCliente;
            this.Agencia = pAgencia;
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
