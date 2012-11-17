using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoftSistBancario.Modelo
{
    public abstract class Cliente
    {
        private StatusCliente _status;
        private List<Endereco> _Enderecos;
        private List<Telefone> _Telefones;

        public string Nome { get; set; }

        public List<Endereco> Enderecos
        {
            get { return _Enderecos; }
        }

        public List<Telefone> Telefones
        {
            get { return _Telefones; }
        }

        public StatusCliente Status
        {
            get { return _status; }
        }

        public Cliente()
        {
            _status = StatusCliente.Potencial;
        }

        public void Ativar()
        {
            _status = StatusCliente.Ativo;
        }

        public void Desativar()
        {
            _status = StatusCliente.Inativo;
        }

        public void AdionarTelefone(String pDDD, String pNumero, TipoTelefone pTipo)
        {
            Telefone telefone = new Telefone(pDDD,pNumero,pTipo);
            _Telefones.Add(telefone);
        }

        // Adicionar endereços, conforme foi feito em adicionar telefones;

    }
}
