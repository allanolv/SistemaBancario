using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Infnet.EngSoftSistBancario.Modelo;
using NUnit.Framework;

namespace Infnet.EngSoftSistBancario.Testes
{
    /// <summary>
    /// Summary description for SaqueTest
    /// </summary>
    [TestFixture]
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


        [Test]
        public void TestarDataEfetivacao()
        {
            DateTime data_efetivacao = DateTime.Parse("10/10/2012");
            saque.DataEfetivacao = data_efetivacao;

            Assert.AreEqual(data_efetivacao, saque.DataEfetivacao);
        }

        [Test]
        public void TestarValor()
        {
            Decimal valor = Decimal.Parse("1200.12");
            saque.Valor = valor;

            Assert.AreEqual(valor, saque.Valor);
        }
    }
}
