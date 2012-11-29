using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infnet.EngSoftSistBancario.Modelo;
using Infnet.EngSoftSistBancario.Repositorio.Excecoes;
using System.Reflection;

namespace Infnet.EngSoftSistBancario.Repositorio
{
    public class RepositorioClientePessoaFisica
    {
        private static RepositorioClientePessoaFisica instanciaDoRepositorio = null;
        private List<PessoaFisica> _lstCliente;

        private RepositorioClientePessoaFisica()
        {
            _lstCliente = new List<PessoaFisica>();
        }

        public static RepositorioClientePessoaFisica Instancia()
        {
            if (instanciaDoRepositorio == null)
                instanciaDoRepositorio = new RepositorioClientePessoaFisica();
            return instanciaDoRepositorio;
        }

        public PessoaFisica ObterCPF(String pCPF) 
        {
            return _lstCliente.Where(c => c.CPF == pCPF).Cast<PessoaFisica>().FirstOrDefault();
        }


        public void Inserir(PessoaFisica pPessoaFisica)
        {
            PessoaFisica pessoafisica = ObterCPF(pPessoaFisica.CPF);
            if (pessoafisica!=null)
                throw new Excecoes.ExClienteExistente("Cliente já existe");
            _lstCliente.Add(pPessoaFisica);
        }

        public void Alterar(PessoaFisica pPessoaFisica)
        {
            PessoaFisica pessoafisica = ObterCPF(pPessoaFisica.CPF);
            if (pessoafisica != null)
            {
                PropertyInfo[] campos = pessoafisica.GetType().GetProperties();
                foreach (PropertyInfo campo in campos)
                {
                    if (campo.CanWrite)
                        campo.SetValue(pessoafisica, pPessoaFisica.GetType().GetProperty(campo.Name).GetValue(pPessoaFisica, null), null);
                }
            }
            else
                throw new ExClienteNaoEncontrado("Não possível encontrar o cliente cadastrado. ");
        }

        public List<PessoaFisica> ListarClientesAtivos()
        {
            return _lstCliente.Where(cliente => cliente.Status == StatusCliente.Ativo).ToList();
        }

        public List<PessoaFisica> ListarClientesPotencial()
        {
            return _lstCliente.Where(cliente => cliente.Status == StatusCliente.Potencial).ToList();
        }
    }
}
