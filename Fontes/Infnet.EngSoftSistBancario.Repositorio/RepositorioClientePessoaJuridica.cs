using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using Infnet.EngSoftSistBancario.Modelo;
using Infnet.EngSoftSistBancario.Repositorio;
using Infnet.EngSoftSistBancario.Repositorio.Excecoes;

namespace Infnet.EngSoftSistBancario.Repositorio
{
    public class RepositorioClientePessoaJuridica
    {
        private static RepositorioClientePessoaJuridica instanciaDoRepositorio = null;
        private List<PessoaJuridica> _lstCliente;

        private RepositorioClientePessoaJuridica()
        {
            _lstCliente = new List<PessoaJuridica>();
        }

        public static RepositorioClientePessoaJuridica Instancia()
        {
            if (instanciaDoRepositorio == null)
                instanciaDoRepositorio = new RepositorioClientePessoaJuridica();
            return instanciaDoRepositorio;
        }

        public PessoaJuridica ObterCNPJ(String pCNPJ)
        {
            return _lstCliente.Where(c => c.CNPJ == pCNPJ).Cast<PessoaJuridica>().FirstOrDefault();
        }


        public void Inserir(PessoaJuridica pPessoaJuridica)
        {
            try
            {
                PessoaJuridica pessoaJuridica = ObterCNPJ(pPessoaJuridica.CNPJ);
                if (pessoaJuridica != null)
                    throw new Excecoes.ExClienteExistente("Cliente já existe. ");
                _lstCliente.Add(pPessoaJuridica);
            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível incluir o cliente. " + Environment.NewLine + e.Message);
            }
        }

        public void Alterar(PessoaJuridica pPessoaJuridica)
        {
            try
            {
                PessoaJuridica pessoajuridica = ObterCNPJ(pPessoaJuridica.CNPJ);
                if (pessoajuridica != null)
                {
                    PropertyInfo[] campos = pessoajuridica.GetType().GetProperties();
                    foreach (PropertyInfo campo in campos)
                    {
                        if (campo.CanWrite)
                            campo.SetValue(pessoajuridica, pPessoaJuridica.GetType().GetProperty(campo.Name).GetValue(pPessoaJuridica, null), null);
                    }
                }
                else
                    throw new ExClienteNaoEncontrado("Não possível encontrar o cliente cadastrado. ");
            }
            catch (Exception e)
            {
                throw new Exception("Não possível alterar o cliente. " + Environment.NewLine + e.Message);
            }
        }

        public List<PessoaJuridica> ListarClientesAtivos()
        {
            return _lstCliente.Where(cliente => cliente.Status == StatusCliente.Ativo).ToList();
        }

        public List<PessoaJuridica> ListarClientesPotencial()
        {
            return _lstCliente.Where(cliente => cliente.Status == StatusCliente.Potencial).ToList();
        }
    }
}
