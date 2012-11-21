using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Infnet.EngSoftSistBancario.Modelo;
using Infnet.EngSoftSistBancario.Repositorio;
using NUnit.Framework;

namespace Infnet.EngSoftSistBancario.Testes
{
    /// <summary>
    /// Summary description for RepositorioContaCorrenteTest
    /// </summary>
    [TestFixture]
    public class RepositorioContaCorrenteTest
    {
        RepositorioContaCorrente repositorioContaCorrente;

        public RepositorioContaCorrenteTest()
        {
            //
            // TODO: Add constructor logic here
            //
            repositorioContaCorrente = RepositorioContaCorrente.Instancia();

        }

        [Test]
        public void TestarInstanciaUnica()
        {
            RepositorioContaCorrente repositorio1 = repositorioContaCorrente;
            RepositorioContaCorrente repositorio2 = RepositorioContaCorrente.Instancia();

            Assert.AreSame(repositorio1, repositorio2);
        }

    }
}
