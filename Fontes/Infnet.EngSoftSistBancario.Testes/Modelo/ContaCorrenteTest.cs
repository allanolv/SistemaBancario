using Infnet.EngSoftSistBancario.Modelo;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Infnet.EngSoftSistBancario.Testes
{
    
    
    /// <summary>
    ///This is a test class for ContaCorrenteTest and is intended
    ///to contain all ContaCorrenteTest Unit Tests
    ///</summary>
    [TestFixture]
    public class ContaCorrenteTest
    {
        private ContaCorrente contacorrente;

        public ContaCorrenteTest()
        {
            contacorrente = new ContaCorrente();
        }

        internal virtual ContaCorrente Createcontacorrente()
        {
            ContaCorrente target = new ContaCorrente();
            return target;

        }

        /// <summary>
        ///Este conta especial
        ///</summary>
        [Test]
        public void contaEspecialTest()
        {
            /*ContaCorrente target = new ContaCorrente(); // TODO: Initialize to an appropriate value
            List<Especial> expected = null; // TODO: Initialize to an appropriate value
            List<Especial> actual;
            target.contaEspecial = expected;
            actual = target.contaEspecial;
            Assert.AreEqual(expected, actual);/*/
            Assert.Fail("Teste ainda não implementado");
        }

        /// <summary>
        ///A test for contaNormal
        ///</summary>
        [Test()]
        public void contaNormalTest()
        {
            /*ContaCorrente target = new ContaCorrente(); // TODO: Initialize to an appropriate value
            List<Normal> expected = null; // TODO: Initialize to an appropriate value
            List<Normal> actual;
            target.contaNormal = expected;
            actual = target.contaNormal;
            Assert.AreEqual(expected, actual);*/
            Assert.Fail("Teste ainda não implementado");
        }
    }
}
