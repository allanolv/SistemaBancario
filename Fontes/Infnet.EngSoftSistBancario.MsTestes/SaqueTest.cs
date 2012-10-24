using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Infnet.EngSoftSistBancario.Modelo;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Infnet.EngSoftSistBancario.MsTestes
{
    /// <summary>
    /// Summary description for SaqueTest
    /// </summary>
    [TestClass]
    public class SaqueTest
    {

        private Saque saque;

        public SaqueTest()
        {
            //
            // TODO: Add constructor logic here
            //
            saque = new Saque();
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

        [TestMethod]
        public void TestarDataEfetivacao()
        {
            DateTime data_efetivacao = DateTime.Parse("10/10/2012");
            saque.DataEfetivacao = data_efetivacao;

            Assert.AreEqual(data_efetivacao, saque.DataEfetivacao);
        }

        [TestMethod]
        public void TestarValor()
        {
            Decimal valor = Decimal.Parse("1200.12");
            saque.Valor = valor;

            Assert.AreEqual(valor, saque.Valor);
        }
    }
}
