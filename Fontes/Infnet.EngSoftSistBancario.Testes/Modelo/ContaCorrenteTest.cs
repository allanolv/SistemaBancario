using System;
using System.Collections.Generic;
using NUnit.Framework;
using Infnet.EngSoftSistBancario.Modelo;
using Infnet.EngSoftSistBancario.Repositorio;

namespace Infnet.EngSoftSistBancario.Testes
{
    
    
    /// <summary>
    ///This is a test class for ContaCorrenteTest and is intended
    ///to contain all ContaCorrenteTest Unit Tests
    ///</summary>
    [TestFixture]
    public class ContaCorrenteTest
    {

        [Test]
        public void CriarContaCorrente()
        {
            RepositorioContaCorrente rContaCorrente = RepositorioContaCorrente.Instancia();
            PessoaFisica pessoaFisica = new PessoaFisica();
            pessoaFisica.Nome = "Poliana Corbo";
            pessoaFisica.CPF = "01234";
            ContaCorrente contaCorrente = rContaCorrente.CriarContaCorrente(pessoaFisica,"0312",11);
            Assert.IsNotNull(contaCorrente);
        }

        [Test]
        public void CriarContaCorrenteEspecial()
        {
            RepositorioContaCorrente rContaCorrente = RepositorioContaCorrente.Instancia();
            PessoaFisica pessoaFisica = new PessoaFisica();
            pessoaFisica.Nome = "Ronaldo Corbo";
            pessoaFisica.CPF = "01235";
            ContaCorrenteEspecial contaCorrenteEspecial = rContaCorrente.CriarContaCorrente(pessoaFisica, "0312", 11, 100);
            Assert.IsNotNull(contaCorrenteEspecial);
        }
    }
}
