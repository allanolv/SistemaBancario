using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infnet.EngSoftSistBancario.Modelo;
using Infnet.EngSoftSistBancario.Repositorio.Excecoes;


namespace Infnet.EngSoftSistBancario.Repositorio
{
    public class RepositorioClientes 
    {
        private static RepositorioClientes instanciaDoRepositorio = null;
        private List<Cliente> _lstCliente;

        private RepositorioClientes()
        {
            _lstCliente = new List<Cliente>();
        }

        public static RepositorioClientes Instancia()
        {
            if (instanciaDoRepositorio == null)
                instanciaDoRepositorio = new RepositorioClientes();
            return instanciaDoRepositorio;
        }


        public void Inserir<C>(C pCliente) where C : Cliente
        {
            throw new NotImplementedException();
            /*
            try
            {
                // Implementar verificação para saber se o cliente já foi incluído.
                // Para implementar essa parte deve-se resolver o problema de se obter um 
                // cliente através de seu código de identificação;

                Int32 v = 
                _lstCliente.Add(pCliente);
            }
            catch (Exception e)
            {
                throw new Exception("Não possível inserir o cliente. " + Environment.NewLine + e.Message);
            }
             */
        }

        public void Alterar<C>(C pCliente) where C : Cliente
        {
            Int32 vIndex = _lstCliente.IndexOf(pCliente);
            if (vIndex >= 0)
                _lstCliente[vIndex] = pCliente;
            else
                throw new ExClienteNaoEncontrado("Cliente não encontrado");
        }

        public PessoaFisica ObterCPF(String pCPF) 
        {
            return _lstCliente.Where(c => c.GetType().Name==typeof(PessoaFisica).Name && 
                ((PessoaFisica)c).CPF == pCPF).Cast<PessoaFisica>().FirstOrDefault();
        }

        public PessoaJuridica ObterCNPJ(String pCNPJ)
        {
            return _lstCliente.Where(c => c.GetType().Name==typeof(PessoaJuridica).Name && 
                ((PessoaJuridica)c).CNPJ == pCNPJ).Cast<PessoaJuridica>().FirstOrDefault();
        }

        public void DesativarCliente(Cliente pCliente)
        {
            Int32 vIndex = _lstCliente.IndexOf(pCliente);

            if (vIndex >= 0)
            {
                if (_lstCliente[vIndex].Status == StatusCliente.Potencial)
                    throw new ExDesativarClientePotencial("Não é possível desativar um cliente em potencial");
                else
                    _lstCliente[vIndex].Desativar();
            }
            else
                throw new ExClienteNaoEncontrado("Cliente não encontrado");
        }

        public void AtivarCliente(Cliente pCliente)
        {
            Int32 vIndex = _lstCliente.IndexOf(pCliente);

            if (vIndex >= 0)
                _lstCliente[vIndex].Ativar();
            else
                throw new ExClienteNaoEncontrado("Cliente não encontrado");
        }

        public List<C> ListarClientesAtivos<C>() where C : Cliente
        {
            return _lstCliente.Where(cliente => cliente.GetType().Name == typeof(C).Name && 
                cliente.Status==StatusCliente.Ativo).Cast<C>().ToList();
        }

        public List<C> ListarClientesPotencial<C>() where C : Cliente
        {
            return _lstCliente.Where(cliente => cliente.GetType().Name == typeof(C).Name && 
                cliente.Status == StatusCliente.Potencial).Cast<C>().ToList();
        }
    }
}
