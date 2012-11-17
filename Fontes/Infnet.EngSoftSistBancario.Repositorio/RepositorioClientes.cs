using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infnet.EngSoftSistBancario.Modelo;

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


        public Boolean Inserir(Cliente pCliente)
        {
            Boolean _result = false;
            try
            {
                _lstCliente.Add(pCliente);
                _result = true;
            }
            catch (Exception e)
            {
                throw new Exception("Não possível inserir o cliente. " + Environment.NewLine + e.Message);
            }
            return _result;
        }

        public Boolean Alterar(Cliente pCliente)
        {
            // Pensar depois.
            Boolean _result = false;
            return _result;
        }

        public Cliente ObterCPF(String pCPF)
        {
            return _lstCliente.Where(c => c is PessoaFisica && ((PessoaFisica)c).CPF == pCPF).FirstOrDefault();
        }

        public Cliente ObterCNPJ(String pCNPJ)
        {
            return _lstCliente.Where(c => c is PessoaJuridica && ((PessoaJuridica)c).CNPJ == pCNPJ).FirstOrDefault();
        }

        public void DesativarCliente(Cliente pCliente)
        {
            // Implementar Importante
        }

        public void AtivarCliente(Cliente pCliente)
        {
            // Implementar Importante
        }

        public List<PessoaFisica> ListarClientesPessoaFisicaAtiva()
        {
            // Implementar por último
            return null;
        }

        public List<PessoaFisica> ListarClientesPessoaJuridicaAtiva()
        {
            // Implementar por último
            return null;
        }

        public List<PessoaFisica> ListarClientesPessoaPotencial()
        {
            // Implementar por último
            return null;
        }
    }
}
