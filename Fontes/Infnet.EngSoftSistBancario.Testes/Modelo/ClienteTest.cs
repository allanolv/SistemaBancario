using Infnet.EngSoftSistBancario.Modelo;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infnet.EngSoftSistBancario.Testes
{

    /// <summary>
    ///This is a test class for ClienteTest and is intended
    ///to contain all ClienteTest Unit Tests
    ///</summary>
    [TestFixture]
    public class ClienteTest
    {
        PessoaFisica esperado;
   
        /// <summary>
        ///A test for Ativo
        ///</summary>
        [Test]
        public void AtivoTest()
        {
            esperado = new PessoaFisica();
            esperado.Nome = "Glebson Lima";
            esperado.Ativar();
            PessoaFisica atual;
            atual = esperado;
            Assert.AreEqual(atual, esperado);
 
        }

        /// <summary>
        ///A test for Enderecos
        ///</summary>
        [Test]
        public void EnderecosTest()
        {
            esperado = new PessoaFisica();
            esperado.Nome = "Glebson Lima";
            esperado.CPF = "871.852.323/02";
            esperado.Renda = 2000;
            esperado.AdicionarEndereco(TipoLogradouro.Avenida, "Ernani Cardoso", "500", "apt 240", "Cascadura", "Rio de Janeiro", "RJ", "85411-080");
            Endereco atual = esperado.Enderecos.Where(e => e.CEP == "85411-080").FirstOrDefault();
            Assert.Contains(atual, esperado.Enderecos);
        }

        /// <summary>
        ///A test for Nome
        ///</summary>
        [Test]
        public void InfoBasicoTest()
        {
           List<PessoaFisica> lista = new List<PessoaFisica>();
           PessoaFisica Tel = new PessoaFisica { Nome = "Glebson Lima", CPF = "871.852.323/02", Renda = 2000};
           lista.Add(Tel);
           List<PessoaFisica> esperado = lista;
           List<PessoaFisica> atual;
           atual = esperado.ToList();
           Assert.AreEqual(esperado, atual);
            
           
        }

        /// <summary>
        ///A test for Telefones
        ///</summary>
        [Test]
        public void TelefonesTest()
        {
            esperado = new PessoaFisica();
            esperado.Nome = "Glebson Lima";
            esperado.CPF = "871.852.323/02" ;
            esperado.Renda = 2000;
            esperado.AdicionarTelefone(TipoTelefone.Celular, "021", "8587-7425");
            Telefone atual = esperado.Telefones.Where(t => t.Numero == "8587-7425").FirstOrDefault();
            Assert.Contains(atual, esperado.Telefones);
        }
    }
}
