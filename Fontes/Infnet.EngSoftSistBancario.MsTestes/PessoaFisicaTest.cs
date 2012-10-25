using Infnet.EngSoftSistBancario.Modelo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Infnet.EngSoftSistBancario.MsTestes
{
    
    
    /// <summary>
    ///This is a test class for PessoaFisicaTest and is intended
    ///to contain all PessoaFisicaTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PessoaFisicaTest
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
        ///A test for PessoaFisica Constructor
        ///</summary>
        [TestMethod()]
        public void PessoaFisicaConstructorTest()
        {
            PessoaFisica target = new PessoaFisica();
        }

        /// <summary>
        ///A test for CPF
        ///</summary>
        [TestMethod()]
        public void CPFTest()
        {
            PessoaFisica target = new PessoaFisica();
            string expected = "11111111111";
            string actual;
            target.CPF = expected;
            actual = target.CPF;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Renda
        ///</summary>
        [TestMethod()]
        public void RendaTest()
        {
            PessoaFisica target = new PessoaFisica();
            Decimal expected = 1000000;
            Decimal actual;
            target.Renda = expected;
            actual = target.Renda;
            Assert.AreEqual(expected, actual);
        }
    }
}
