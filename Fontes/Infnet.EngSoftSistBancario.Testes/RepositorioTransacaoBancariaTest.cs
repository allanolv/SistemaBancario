using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Infnet.EngSoftSistBancario.Repositorio;
using Infnet.EngSoftSistBancario.Modelo;
using NUnit.Framework;

namespace Infnet.EngSoftSistBancario.MsTestes
{
    /// <summary>
    /// Summary description for RepositorioTransacaoBancariaTest
    /// </summary>
    [TestFixture]
    public class RepositorioTransacaoBancariaTest
    {
        public RepositorioTransacaoBancariaTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        [Test]
        public void TestarInstanciaUnica()
        {
            RepositorioTransacaoBancaria repositorio1 = RepositorioTransacaoBancaria.Instancia();
            RepositorioTransacaoBancaria repositorio2 = RepositorioTransacaoBancaria.Instancia();

            Assert.AreSame(repositorio1, repositorio2);
        }

    }
}
