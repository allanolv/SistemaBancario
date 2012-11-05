using Infnet.EngSoftSistBancario.Modelo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Infnet.EngSoftSistBancario.MsTestes
{
    
    
    /// <summary>
    ///This is a test class for ContaCorrenteTest and is intended
    ///to contain all ContaCorrenteTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ContaCorrenteTest
    {
        private ContaCorrente contacorrente;

        public ContaCorrenteTest()
        {
            contacorrente = new ContaCorrente();
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
        internal virtual ContaCorrente Createcontacorrente()
        {
            ContaCorrente target = new ContaCorrente();
            return target;

        }

        /// <summary>
        ///Este conta especial
        ///</summary>
        [TestMethod()]
        public void contaEspecialTest()
        {
            ContaCorrente target = new ContaCorrente(); // TODO: Initialize to an appropriate value
            List<Especial> expected = null; // TODO: Initialize to an appropriate value
            List<Especial> actual;
            target.contaEspecial = expected;
            actual = target.contaEspecial;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for contaNormal
        ///</summary>
        [TestMethod()]
        public void contaNormalTest()
        {
            ContaCorrente target = new ContaCorrente(); // TODO: Initialize to an appropriate value
            List<Normal> expected = null; // TODO: Initialize to an appropriate value
            List<Normal> actual;
            target.contaNormal = expected;
            actual = target.contaNormal;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
