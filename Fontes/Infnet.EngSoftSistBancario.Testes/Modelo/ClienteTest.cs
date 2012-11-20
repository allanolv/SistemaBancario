using Infnet.EngSoftSistBancario.Modelo;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Infnet.EngSoftSistBancario.Testes
{

    /// <summary>
    ///This is a test class for ClienteTest and is intended
    ///to contain all ClienteTest Unit Tests
    ///</summary>
    [TestFixture]
    public class ClienteTest
    {

        private Cliente cliente;

        /// <summary>
        ///A test for Ativo
        ///</summary>
        [Test]
        public void AtivoTest()
        {
            /* Refatorar
             * cliente = new Cliente { Nome = "Ana", Ativo = true };
            bool expected = true;
            bool actual;
            cliente.Ativo = expected;
            actual = cliente.Ativo;
            Assert.AreEqual(expected, actual);
            */
        }

        /// <summary>
        ///A test for Enderecos
        ///</summary>
        [Test]
        public void EnderecosTest()
        {
            /* Refatorar
             * 
            cliente = new Cliente();
            List<Endereco> listaEnd = new List<Endereco>();
            Endereco End = new Endereco { Logradouro = "Rua A", Bairro = "B", CEP = "20000-000", Cidade = "Rio de Janeiro", 
                                            Complemento = "apt101", Numero = 222, TipoDeLogradouro = "RUA", UF = "RJ" };
            listaEnd.Add(End);
            List<Endereco> expected = listaEnd;
            List<Endereco> actual;
            cliente.Enderecos = expected;
            actual = cliente.Enderecos;
            Assert.AreEqual(expected, actual);
             */
        }

        /// <summary>
        ///A test for Nome
        ///</summary>
        [Test]
        public void NomeTest()
        {
            /* Refatorar
            Cliente target = new Cliente();
            string expected = "ANA";
            string actual;
            target.Nome = expected;
            actual = target.Nome;
            Assert.AreEqual(expected, actual);
             */
        }

        /// <summary>
        ///A test for Telefones
        ///</summary>
        [Test]
        public void TelefonesTest()
        {
            /* Refatorar
             * 
            cliente = new Cliente();
            List<Telefone> lista = new List<Telefone>();
            Telefone Tel = new Telefone { Numero = "2222-2222", DDD = 21, Tipo = "Celular" };
            lista.Add(Tel);
            List<Telefone> expected = lista;
            List<Telefone> actual;
            cliente.Telefones = expected;
            actual = cliente.Telefones;
            Assert.AreEqual(expected, actual);
             */
        }
    }
}
