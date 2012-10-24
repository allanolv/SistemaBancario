using Infnet.EngSoftSistBancario.Modelo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Infnet.EngSoftSistBancario.MsTestes
{
    
    
    /// <summary>
    ///This is a test class for PessoaJuridicaTest and is intended
    ///to contain all PessoaJuridicaTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PessoaJuridicaTest
    {


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


        /// <summary>
        ///A test for PessoaJuridica Constructor
        ///</summary>
        [TestMethod()]
        public void PessoaJuridicaConstructorTest()
        {
            PessoaJuridica target = new PessoaJuridica();
        }



        /// <summary>
        ///A test for CNPJ
        ///</summary>
        [TestMethod()]
        public void CNPJTest()
        {
            PessoaJuridica target = new PessoaJuridica();// TODO: Initialize to an appropriate value
            string expected = "11111111111111"; // TODO: Initialize to an appropriate value
            string actual;
            target.CNPJ = expected;
            actual = target.CNPJ;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Receita
        ///</summary>
        [TestMethod()]
        public void ReceitaTest()
        {
            PessoaJuridica target = new PessoaJuridica(); // TODO: Initialize to an appropriate value
            Decimal expected = 10000; // TODO: Initialize to an appropriate value
            Decimal actual;
            target.Receita = expected;
            actual = target.Receita;
            Assert.AreEqual(expected, actual);
        }
    }
}
