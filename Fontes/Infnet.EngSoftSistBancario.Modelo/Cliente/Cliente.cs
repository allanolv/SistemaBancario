using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infnet.EngSoftSistBancario.Modelo.Excecoes;

namespace Infnet.EngSoftSistBancario.Modelo
{
    public abstract class Cliente
    {
        private String _documento;

        private StatusCliente _status;
        private List<Endereco> _Enderecos;
        private List<Telefone> _Telefones;

        // Atributos
        public string Nome { get; set; }

        public String Documento
        {
            get { return _documento; }
            protected set { _documento = value; }
        }

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


        // Métodos
        public Cliente()
        {
            _status = StatusCliente.Potencial;
            _Enderecos = new List<Endereco>();
            _Telefones = new List<Telefone>();
        }

        private Endereco EncontrarEndereco(TipoLogradouro pTipoLogradouro,
            String pLogradouro, String pNumero, String pComplemento, String pBairro, String pCidade, String pUF, String pCEP)
        {
            return _Enderecos.Where(e => e.TipoDeLogradouro == pTipoLogradouro &&
                e.Logradouro == pLogradouro &&
                e.Numero == pNumero &&
                e.Complemento == pComplemento &&
                e.Bairro == pBairro &&
                e.Cidade == pCidade &&
                e.UF == pUF &&
                e.CEP == pCEP).FirstOrDefault();
        }
        private Telefone EncontarTelefone(String pDDD, String pNumero)
        {
            return _Telefones.Where(t => t.DDD == pDDD && t.Numero == pNumero).FirstOrDefault();
        }

        protected abstract void AlterarNumeroDocumento();

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
            Telefone telefone = EncontarTelefone(pDDD,pNumero);

            if (telefone!=null)
                throw new ExTelefoneExistente("Telefone existente");
            else
            {
                telefone = new Telefone(pTipo, pDDD, pNumero);
                _Telefones.Add(telefone);
            }
        }

        public void AdicionarEndereco(TipoLogradouro pTipoLogradouro, String pLogradouro, String pNumero, String pComplemento, String pBairro, String pCidade, String pUF, String pCEP)
        {
            Endereco endereco = EncontrarEndereco(pTipoLogradouro, pLogradouro, pNumero, pComplemento, pBairro, pCidade, pUF, pCEP);

            if (endereco != null)
                throw new ExEnderecoExistente("Endereço existente");
            else
            {
                endereco = new Endereco(pTipoLogradouro, pLogradouro, pNumero, pComplemento, pBairro, pCidade, pUF, pCEP);
                _Enderecos.Add(endereco);
            }
        }

        public void ExcluirTelefone(String pDDD, String pNumero)
        {
            Telefone telefone = EncontarTelefone(pDDD,pNumero);
            if (telefone == null)
                throw new ExTelefoneInexistente("Telefone inexistente");
            else
                _Telefones.Remove(telefone);
        }
        public void ExcluirEndereco(TipoLogradouro pTipoLogradouro, String pLogradouro, String pNumero, String pComplemento, String pBairro, String pCidade, String pUF, String pCEP)
        {
            Endereco endereco = EncontrarEndereco(pTipoLogradouro, pLogradouro, pNumero, pComplemento, pBairro, pCidade, pUF, pCEP);
            if (endereco == null)
                throw new ExEnderecoInexistente("Endereço inexistente");
            else
                _Enderecos.Remove(endereco);
        }
    }
}
