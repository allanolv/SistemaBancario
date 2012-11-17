using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Infnet.EngSoftSistBancario.Repositorio;
using NUnit.Framework;

namespace Infnet.EngSoftSistBancario.MsTestes
{
    /// <summary>
    /// Summary description for RepositorioContaCorrenteTest
    /// </summary>
    [TestFixture]
    public class RepositorioContaCorrenteTest
    {
        RepositorioClientes repositorioClientes;

        public RepositorioContaCorrenteTest()
        {
            //
            // TODO: Add constructor logic here
            //

        }

        [Test]
        public void TestarInstanciaUnica()
        {
            RepositorioContaCorrente repositorio1 = RepositorioContaCorrente.Instancia();
            RepositorioContaCorrente repositorio2 = RepositorioContaCorrente.Instancia();

            Assert.AreSame(repositorio1, repositorio2);
        }
    }
}
