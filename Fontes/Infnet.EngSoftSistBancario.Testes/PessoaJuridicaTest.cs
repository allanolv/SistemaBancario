using Infnet.EngSoftSistBancario.Modelo;
using NUnit.Framework;
using System;

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
            string expected = "11111111111111"; // TODO: Initialize to an appropriate value
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
            /* Criar um objeto PessoaJuridica
             * Adicionar atributos os atributos do objeto;
             * Adicionar um telefone usando o método específico;
             * Recuperar através do atributo da lista;
             * Usar o comando assert para verificar os atributos estão com o mesmo valor;
             * AreEqual(esperado, atual);s
             */
        }
    }
}
