using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Infnet.EngSoftSistBancario.Modelo;
using Infnet.EngSoftSistBancario.Repositorio;
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

        public RepositorioClienteTest()
        {
            repositorioCliente = RepositorioClientes.Instancia();
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

            repositorioCliente.Inserir<PessoaFisica>(pessoaFisica);
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

            repositorioCliente.Inserir<PessoaJuridica>(pessoaJuridica);
            return pessoaJuridica;
        }

        public void DesativarTodosClientes()
        {
            List<PessoaFisica> listaClientePessoaFisicaAtivos = repositorioCliente.ListarClientesAtivos<PessoaFisica>();
            foreach (PessoaFisica cliente in listaClientePessoaFisicaAtivos)
            {
                repositorioCliente.AtivarCliente(cliente);
                repositorioCliente.DesativarCliente(cliente);
            }

            List<PessoaJuridica> listaClientePessoaJuridicaAtivos = repositorioCliente.ListarClientesAtivos<PessoaJuridica>();
            foreach (PessoaJuridica cliente in listaClientePessoaJuridicaAtivos)
            {
                repositorioCliente.AtivarCliente(cliente);
                repositorioCliente.DesativarCliente(cliente);
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
        public void InclusaoClientePessoaFisica()
        {
            PessoaFisica esperado = IncluirUmClientePessoaFisica("101");
            PessoaFisica atual = repositorioCliente.ObterCPF("101");
            Assert.AreSame(esperado, atual);
        }
        
        [Test]
        public void IncluirClientePessoaJuridica()
        {
            PessoaJuridica esperado = IncluirUmClientePessoaJuridica("1001");
            PessoaJuridica atual = repositorioCliente.ObterCNPJ("1001");
            Assert.AreSame(esperado, atual);
        }

        [Test]
        public void AtivarCliente()
        {
            PessoaFisica esperado1 = IncluirUmClientePessoaFisica("201");
            repositorioCliente.AtivarCliente(esperado1);
            Assert.AreEqual(StatusCliente.Ativo, esperado1.Status);

            PessoaJuridica esperado2 = IncluirUmClientePessoaJuridica("2001");
            repositorioCliente.AtivarCliente(esperado2);
            Assert.AreEqual(StatusCliente.Ativo, esperado2.Status);
        }
        
        [Test]
        public void DesativarCliente()
        {
            PessoaFisica esperado1 = IncluirUmClientePessoaFisica("301");
            repositorioCliente.AtivarCliente(esperado1);
            repositorioCliente.DesativarCliente(esperado1);
            Assert.AreEqual(StatusCliente.Inativo, esperado1.Status);

            PessoaJuridica esperado2 = IncluirUmClientePessoaJuridica("3001");
            repositorioCliente.AtivarCliente(esperado2);
            repositorioCliente.DesativarCliente(esperado2);
            Assert.AreEqual(StatusCliente.Inativo, esperado2.Status);
        }

        [Test]
        public void ListarClienteAtivos()
        {
            DesativarTodosClientes();
            IncluirUmClientePessoaFisica("401");
            PessoaFisica pessoafisica = repositorioCliente.ObterCPF("401");
            repositorioCliente.AtivarCliente(pessoafisica);
            Int32 esperado = repositorioCliente.ListarClientesAtivos<PessoaFisica>().Count();
            Int32 atual = 1;
            Assert.AreEqual(esperado, atual);

            IncluirUmClientePessoaJuridica("4001");
            PessoaJuridica pessoaJuridica = repositorioCliente.ObterCNPJ("4001");
            repositorioCliente.AtivarCliente(pessoaJuridica);
            esperado = repositorioCliente.ListarClientesAtivos<PessoaJuridica>().Count();
            Assert.AreEqual(esperado, atual);

            // Verificar uma forma de lista todos os clientes independente se for Pessoa Física ou Jurídica.
        }

        [Test]
        public void ListarClientePotencial()
        {
            DesativarTodosClientes();
            IncluirUmClientePessoaFisica("501");
            // Verificar uma forma de lista todos os clientes independente se for Pessoa Física ou Jurídica.

            Int32 esperado = repositorioCliente.ListarClientesPotencial<PessoaFisica>().Count();
            Int32 atual = 1;
            Assert.AreEqual(esperado, atual);

            IncluirUmClientePessoaJuridica("5001");
            esperado = repositorioCliente.ListarClientesPotencial<PessoaJuridica>().Count();
            Assert.AreEqual(esperado, atual);
        }

        public void AlterarCliente()
        {


        }
    
    }
}
