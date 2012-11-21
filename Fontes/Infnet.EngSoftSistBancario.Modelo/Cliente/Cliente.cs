using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infnet.EngSoftSistBancario.Modelo.Excecoes;

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
            _Enderecos = new List<Endereco>();
            _Telefones = new List<Telefone>();
        }

        public void Ativar()
        {
            _status = StatusCliente.Ativo;
        }

        public void Desativar()
        {
            if (_status == StatusCliente.Potencial)
                throw new ExMudarStatusCliente("Não é possível desativar um cliente em potencial");
            _status = StatusCliente.Inativo;
        }

        public void AdicionarTelefone(TipoTelefone pTipo, String pDDD, String pNumero)
        {
            Int32 vCo = _Telefones.Where(t => t.DDD == pDDD && t.Numero == pNumero).Count();

            if (vCo > 0)
                throw new ExTelefoneExistente("Telefone existente");
            else
            {
                Telefone telefone = new Telefone(pTipo, pDDD, pNumero);
                _Telefones.Add(telefone);
            }
        }

        public void AdicionarEndereco(TipoLogradouro pTipoLogradouro, String pLogradouro, String pNumero, String pComplemento, String pBairro, String pCidade, String pUF, String pCEP)
        {
            Endereco endereco = new Endereco(pTipoLogradouro, pLogradouro, pNumero, pComplemento, pBairro, pCidade, pUF, pCEP);
            _Enderecos.Add(endereco); 
        }
      
    }
}
