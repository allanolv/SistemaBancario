using NUnit.Framework;
using System;
using Infnet.EngSoftSistBancario.Modelo;
using System.Collections.Generic;

namespace Infnet.EngSoftSistBancario.MsTestes
{
    
    
    /// <summary>
    ///This is a test class for PessoaJuridicaTest and is intended
    ///to contain all PessoaJuridicaTest Unit Tests
    ///</summary>
    [TestFixture]
    public class PessoaJuridicaTest
    {

        PessoaJuridica pessoaJuridica;


        /// <summary>
        ///A test for CNPJ
        ///</summary>
        [Test]
        public void CNPJTest()
        {
            pessoaJuridica = new PessoaJuridica();// TODO: Initialize to an appropriate value
            string expected = "35.380.399/0001-88"; // TODO: Initialize to an appropriate value
            string actual;
            pessoaJuridica.CNPJ = expected;
            actual = pessoaJuridica.CNPJ;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Receita
        ///</summary>
        [Test]
        public void ReceitaTest()
        {
            pessoaJuridica = new PessoaJuridica(); // TODO: Initialize to an appropriate value
            Decimal expected = 10000; // TODO: Initialize to an appropriate value
            Decimal actual;
            pessoaJuridica.Receita = expected;
            actual = pessoaJuridica.Receita;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IncluirTelefonesTest()
        {
            pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.Nome = "Glebson Lima";
            pessoaJuridica.CNPJ = "35.380.399/0001-88";
            pessoaJuridica.Receita = 10000;
            pessoaJuridica.AdicionarTelefone("(021)", "3396-7487", TipoTelefone.Celular);

            PessoaJuridica esperado = pessoaJuridica;
            PessoaJuridica atual;
            atual = esperado;
            Assert.AreEqual(esperado, atual);


        }
    }
}
