using NUnit.Framework;
using System;
using Infnet.EngSoftSistBancario.Modelo;
using Infnet.EngSoftSistBancario.Modelo.Excecoes;
using System.Collections.Generic;
using System.Linq;

namespace Infnet.EngSoftSistBancario.Testes
{

    /// <summary>
    ///This is a test class for ClienteTest and is intended
    ///to contain all ClienteTest Unit Tests
    ///</summary>
    [TestFixture]
    public class PessoaFisicaTest
    {
        PessoaFisica pessoaFisica;

        /// <summary>
        ///A test for Ativo
        ///</summary>
        [Test]
        public void AtivarCliente()
        {
            pessoaFisica = new PessoaFisica();
            pessoaFisica.Nome = "Glebson Lima";
            pessoaFisica.Ativar();
            StatusCliente atual = pessoaFisica.Status;
            StatusCliente esperado = StatusCliente.Ativo;
            Assert.AreEqual(esperado, atual);
        }

        [Test]
        public void DesativarCliente()
        {
            pessoaFisica = new PessoaFisica();
            pessoaFisica.Nome = "Glebson Lima";
            pessoaFisica.CPF = "0005";
            pessoaFisica.Renda = 10000;
            Assert.Throws<ExMudarStatusCliente>(delegate { pessoaFisica.Desativar(); });

        }


        /// <summary>
        ///A test for Enderecos
        ///</summary>
        [Test]
        public void EnderecosTest()
        {
            pessoaFisica = new PessoaFisica();
            pessoaFisica.Nome = "Glebson Lima";
            pessoaFisica.CPF = "871.852.323/02";
            pessoaFisica.Renda = 2000;
            pessoaFisica.AdicionarEndereco(TipoLogradouro.Avenida, "Ernani Cardoso", "500", "apt 240", "Cascadura", "Rio de Janeiro", "RJ", "85411-080");
            Endereco atual = pessoaFisica.Enderecos.Where(e => e.CEP == "85411-080").FirstOrDefault();
            Assert.Contains(atual, pessoaFisica.Enderecos);
        }

        /// <summary>
        ///A test for Nome
        ///</summary>
        [Test]
        public void InfoBasicoTest()
        {
            List<PessoaFisica> lista = new List<PessoaFisica>();
            pessoaFisica = new PessoaFisica { Nome = "Glebson Lima", CPF = "871.852.323/02", Renda = 2000 };
            lista.Add(pessoaFisica);
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
            pessoaFisica = new PessoaFisica();
            pessoaFisica.Nome = "Glebson Lima";
            pessoaFisica.CPF = "871.852.323/02";
            pessoaFisica.Renda = 2000;
            pessoaFisica.AdicionarTelefone(TipoTelefone.Celular, "021", "8587-7425");
            Telefone atual = pessoaFisica.Telefones.Where(t => t.Numero == "8587-7425").FirstOrDefault();
            Assert.Contains(atual, pessoaFisica.Telefones);
        }

        [Test]
        public void IncluirEnderecoExistente()
        {
            pessoaFisica = new PessoaFisica();
            pessoaFisica.Nome = "Glebson Lima";
            pessoaFisica.CPF = "0002";
            pessoaFisica.Renda = 185000;
            pessoaFisica.AdicionarEndereco(TipoLogradouro.Rua, "Maria Carvalho", "80", "", "Padre Miguel", "Rio de Janeiro", "RJ", "21715-280");
            Assert.Throws<ExEnderecoExistente>(delegate { pessoaFisica.AdicionarEndereco(TipoLogradouro.Rua, "Maria Carvalho", "80", "", "Padre Miguel", "Rio de Janeiro", "RJ", "21715-280"); });
        }

        [Test]
        public void IncluirTelefoneExistente()
        {
            pessoaFisica = new PessoaFisica();
            pessoaFisica.Nome = "Glebson Lima";
            pessoaFisica.CPF = "0003";
            pessoaFisica.Renda = 10000;
            pessoaFisica.AdicionarTelefone(TipoTelefone.Celular, "021", "9396-7487");
            Assert.Throws<ExTelefoneExistente>(delegate { pessoaFisica.AdicionarTelefone(TipoTelefone.Celular, "021", "9396-7487"); });
        }

        [Test]
        public void ExcluirTelefone()
        {
            pessoaFisica = new PessoaFisica();
            pessoaFisica.Nome = "Glebson Lima";
            pessoaFisica.CPF = "0004";
            pessoaFisica.Renda = 10000;
            pessoaFisica.AdicionarTelefone(TipoTelefone.Residencial, "021", "2928-0923");
            pessoaFisica.ExcluirTelefone("021", "2928-0923");
            Int32 atual = 0;
            Int32 esperado = pessoaFisica.Telefones.Count();
            Assert.AreEqual(esperado, atual);
        }

        [Test]
        public void ExcluirTelefoneInexistente()
        {
            pessoaFisica = new PessoaFisica();
            pessoaFisica.Nome = "Glebson Lima";
            pessoaFisica.CPF = "0005";
            pessoaFisica.Renda = 10000;
            Assert.Throws<ExTelefoneInexistente>(delegate { pessoaFisica.ExcluirTelefone("021", "8720-0012"); });
        }

        [Test]
        public void ExcluirEndereco()
        {
            pessoaFisica = new PessoaFisica();
            pessoaFisica.Nome = "Glebson Lima";
            pessoaFisica.CPF = "0006";
            pessoaFisica.Renda = 185000;
            pessoaFisica.AdicionarEndereco(TipoLogradouro.Avenida, "das Americas", "500", "sala 240", "Barra da Tijuca", "Rio de Janeiro", "RJ", "81547-505");
            pessoaFisica.ExcluirEndereco(TipoLogradouro.Avenida, "das Americas", "500", "sala 240", "Barra da Tijuca", "Rio de Janeiro", "RJ", "81547-505");
            Int32 esperado = pessoaFisica.Enderecos.Count();
            Int32 atual = 0;
            Assert.AreEqual(esperado, atual);
        }

        [Test]
        public void ExcluirEnderecoInexistente()
        {
            pessoaFisica = new PessoaFisica();
            pessoaFisica.Nome = "Glebson Lima";
            pessoaFisica.CPF = "0007";
            pessoaFisica.Renda = 10000;
            Assert.Throws<ExEnderecoInexistente>(delegate
            {
                pessoaFisica.ExcluirEndereco(TipoLogradouro.Avenida,
                    "das Americas", "500", "sala 240", "Barra da Tijuca", "Rio de Janeiro", "RJ", "81547-505");
            });
        }
    }
}
