using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Infnet.EngSoftSistBancario.Repositorio;
using Infnet.EngSoftSistBancario.Modelo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Infnet.EngSoftSistBancario.MsTestes
{
    /// <summary>
    /// Summary description for RepositorioDeClienteTest
    /// </summary>
    [TestClass]
    public class RepositorioClienteTest
    {
        RepositorioClientes repositorioCliente;
        public RepositorioClienteTest()
        {
            //
            // TODO: Add constructor logic here
            //
            repositorioCliente = RepositorioClientes.Instancia();
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        public void IncluirClientes()
        {
            /* Inclusão do cliente 1 */
            PessoaFisica pessoaFisica = new PessoaFisica();
            pessoaFisica.Nome = "CARLOS HENRIQUE MEIRELES CORBO";
            pessoaFisica.Renda = 1000;
            pessoaFisica.CPF = "001";
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

            /* Inclusão do cliente 2 */

            pessoaFisica = new PessoaFisica();
            pessoaFisica.Nome = "TATIANE MOREIRA DA SILVA CORBO";
            pessoaFisica.Renda = 800;
            pessoaFisica.CPF = "002";
            pessoaFisica.AdicionarTelefone(TipoTelefone.Residencial,
                "021",
                "2121-1233");
            pessoaFisica.AdicionarEndereco(TipoLogradouro.Rua,
                "Rua Maria Carvalho", "80",
                "Casa 1",
                "Padre Miguel",
                "Rio de Janeiro",
                "RJ",
                "21715-280");

            repositorioCliente.Inserir<PessoaFisica>(pessoaFisica);

            /* Inclusão do cliente 3 */
            pessoaFisica = new PessoaFisica();
            pessoaFisica.Nome = "GABRIELA MOREIRA DA SILVA";
            pessoaFisica.Renda = 2500;
            pessoaFisica.CPF = "003";
            pessoaFisica.AdicionarTelefone(TipoTelefone.Residencial,
                "021",
                "2565-2928");
            pessoaFisica.AdicionarEndereco(TipoLogradouro.Travessa,
                "Porto Alegre", "102",
                "Casa 7",
                "Santa Cruz da Serra",
                "Duque de Caxias",
                "RJ",
                "25232-220");

            repositorioCliente.Inserir<PessoaFisica>(pessoaFisica);
            /**************************************************/
            /* Inclusão do cliente 4 */
            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.Nome = "Instituto Infnet";
            pessoaJuridica.Receita = 230000;
            pessoaJuridica.CNPJ = "0001";
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

            /* Inclusão do cliente 5 */
            pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.Nome = "Universo Calçados LTDA";
            pessoaJuridica.Receita = 210000;
            pessoaJuridica.CNPJ = "0002";
            pessoaJuridica.AdicionarTelefone(TipoTelefone.Comercial, "021", "3192-1209");
            pessoaJuridica.AdicionarEndereco(TipoLogradouro.Rua,
                "Rua Antonio Rabelo",
                "312",
                "Lj 05",
                "Centro",
                "Belford Roxo",
                "RJ",
                "25010-020");

            repositorioCliente.Inserir<PessoaJuridica>(pessoaJuridica);
            /**********************************************************/
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



        [TestMethod]
        public void TestarInstanciaUnica()
        {
            RepositorioClientes repositorio1 = repositorioCliente;
            RepositorioClientes repositorio2 = RepositorioClientes.Instancia();

            Assert.AreSame(repositorio1, repositorio2);
        }

        [TestMethod]
        public void ListarClientePotencial()
        {
            DesativarTodosClientes();
            IncluirClientes();
            // Verificar uma forma de lista todos os clientes independente se for Pessoa Física ou Jurídica.

            Int32 esperado = repositorioCliente.ListarClientesPotencial<PessoaFisica>().Count();
            Int32 atual = 3;
            Assert.AreEqual(esperado, atual);

            esperado = repositorioCliente.ListarClientesPotencial<PessoaJuridica>().Count();
            atual = 2;
            Assert.AreEqual(esperado, atual);
        }

    }
}
