using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Infnet.EngSoftSistBancario.Modelo;
using Infnet.EngSoftSistBancario.Repositorio;
using Infnet.EngSoftSistBancario.Repositorio.Excecoes;
using NUnit.Framework;

namespace Infnet.EngSoftSistBancario.Testes
{
    /// <summary>
    /// Summary description for RepositorioDeClienteTest
    /// </summary>
    [TestFixture]
    public class RepositorioClienteTest
    {
        RepositorioClientes repositorioCliente;
        RepositorioClientePessoaFisica rClientePessoaFisica;
        RepositorioClientePessoaJuridica rClientePessoaJuridica;

        public RepositorioClienteTest()
        {
            repositorioCliente = RepositorioClientes.Instancia();
            rClientePessoaFisica = RepositorioClientePessoaFisica.Instancia();
            rClientePessoaJuridica = RepositorioClientePessoaJuridica.Instancia();
        }

        public PessoaFisica IncluirUmClientePessoaFisica(String pCPF)
        {
            PessoaFisica pessoaFisica = new PessoaFisica();
            pessoaFisica.Nome = "CARLOS HENRIQUE MEIRELES CORBO";
            pessoaFisica.Renda = 1000;
            pessoaFisica.CPF = pCPF;
            pessoaFisica.AdicionarTelefone(TipoTelefone.Celular,
                "021",
                "8890-0092");
            pessoaFisica.AdicionarEndereco(TipoLogradouro.Rua,
                "Dona Alice", "S/N",
                "Lt. 39 Qd.22",
                "Vila Tiradentes",
                "São João de Meriti",
                "RJ",
                "25525-290");

            rClientePessoaFisica.Inserir(pessoaFisica);
            return pessoaFisica;
        }


        public PessoaJuridica IncluirUmClientePessoaJuridica(String pCNPJ)
        {
            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.Nome = "Instituto Infnet";
            pessoaJuridica.Receita = 230000;
            pessoaJuridica.CNPJ = pCNPJ;
            pessoaJuridica.AdicionarTelefone(TipoTelefone.Comercial, "021", "2122-8800");
            pessoaJuridica.AdicionarEndereco(TipoLogradouro.Rua,
                "Rua São José",
                "90",
                "2o piso",
                "Centro",
                "Rio de Janeiro",
                "RJ",
                "20010-020");

            rClientePessoaJuridica.Inserir(pessoaJuridica);
            return pessoaJuridica;
        }


        public void DesativarTodosClientes()
        {
            List<Cliente> listaClientesAtivos = repositorioCliente.ListarClientesAtivos();
            List<Cliente> listaClientesPotencial = repositorioCliente.ListarClientesPotencial();
                
            foreach (Cliente cliente in listaClientesAtivos)
            {
                cliente.Desativar();
                if (cliente is PessoaFisica)
                    rClientePessoaFisica.Alterar((PessoaFisica)cliente);
                else 
                    rClientePessoaJuridica.Alterar((PessoaJuridica)cliente);
            }

            foreach (Cliente cliente in listaClientesPotencial)
            {
                cliente.Ativar();
                cliente.Desativar();
                if (cliente is PessoaFisica)
                    rClientePessoaFisica.Alterar((PessoaFisica)cliente);
                else 
                    rClientePessoaJuridica.Alterar((PessoaJuridica)cliente);
            }
        }

        [Test]
        public void TestarInstanciaUnica()
        {
            RepositorioClientes repositorioCliente1 = repositorioCliente;
            RepositorioClientes repositorioCliente2 = RepositorioClientes.Instancia();

            Assert.AreSame(repositorioCliente1, repositorioCliente2);
        }

        [Test]
        public void ListarClienteAtivos()
        {
            DesativarTodosClientes();
            IncluirUmClientePessoaFisica("101");
            PessoaFisica pessoafisica = rClientePessoaFisica.ObterCPF("101");
            pessoafisica.Ativar();
            rClientePessoaFisica.Alterar(pessoafisica);

            IncluirUmClientePessoaJuridica("1001");
            PessoaJuridica pessoaJuridica = rClientePessoaJuridica.ObterCNPJ("1001");
            pessoaJuridica.Ativar();
            rClientePessoaJuridica.Alterar(pessoaJuridica);

            Int32 esperado = repositorioCliente.ListarClientesAtivos().Count();
            Int32 atual = 2;
            Assert.AreEqual(esperado, atual);
        }

        [Test]
        public void ListarClientePotencial()
        {
            DesativarTodosClientes();
            IncluirUmClientePessoaFisica("201");
            PessoaFisica pessoafisica = rClientePessoaFisica.ObterCPF("201");
            rClientePessoaFisica.Alterar(pessoafisica);

            IncluirUmClientePessoaJuridica("2001");
            PessoaJuridica pessoaJuridica = rClientePessoaJuridica.ObterCNPJ("2001");
            rClientePessoaJuridica.Alterar(pessoaJuridica);

            Int32 esperado = repositorioCliente.ListarClientesPotencial().Count();
            Int32 atual = 2;
            Assert.AreEqual(esperado, atual);
        }
    }
}
