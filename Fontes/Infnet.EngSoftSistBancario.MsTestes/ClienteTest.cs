using Infnet.EngSoftSistBancario.Modelo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Infnet.EngSoftSistBancario.MsTestes
{

    /// <summary>
    ///This is a test class for ClienteTest and is intended
    ///to contain all ClienteTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ClienteTest
    {

        private Cliente cliente;

        public ClienteTest()
        {
            cliente = new Cliente();
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
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        internal virtual Cliente CreateCliente()
        {
            Cliente target = new Cliente();
            return target;
        }

        /// <summary>
        ///A test for Ativo
        ///</summary>
        [TestMethod()]
        public void AtivoTest()
        {
            Cliente cliente = new Cliente { Nome = "Ana", Ativo = true };
            bool expected = true;
            bool actual;
            cliente.Ativo = expected;
            actual = cliente.Ativo;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Enderecos
        ///</summary>
        [TestMethod()]
        public void EnderecosTest()
        {
            Cliente target = CreateCliente();
            List<Endereco> listaEnd = new List<Endereco>();
            Endereco End = new Endereco { Logradouro = "Rua A", Bairro = "B", CEP = "20000-000", Cidade = "Rio de Janeiro", 
                                            Complemento = "apt101", Numero = 222, TipoDeLogradouro = "RUA", UF = "RJ" };
            listaEnd.Add(End);
            List<Endereco> expected = listaEnd;
            List<Endereco> actual;
            target.Enderecos = expected;
            actual = target.Enderecos;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Nome
        ///</summary>
        [TestMethod()]
        public void NomeTest()
        {
            Cliente target = CreateCliente();
            string expected = "ANA";
            string actual;
            target.Nome = expected;
            actual = target.Nome;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Telefones
        ///</summary>
        [TestMethod()]
        public void TelefonesTest()
        {
            Cliente target = CreateCliente();
            List<Telefone> lista = new List<Telefone>();
            Telefone Tel = new Telefone { Numero = "2222-2222", DDD = 21, Tipo = "Celular" };
            lista.Add(Tel);
            List<Telefone> expected = lista;
            List<Telefone> actual;
            target.Telefones = expected;
            actual = target.Telefones;
            Assert.AreEqual(expected, actual);
        }
    }
}
