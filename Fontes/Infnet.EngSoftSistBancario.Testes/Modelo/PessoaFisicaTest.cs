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

        [Test]
        public void IncluirEnderecoExistente()
        {
            esperado = new PessoaFisica();
            esperado.Nome = "Glebson Lima";
            esperado.CPF = "0002";
            esperado.Renda = 185000;
            esperado.AdicionarEndereco(TipoLogradouro.Rua, "Maria Carvalho", "80", "", "Padre Miguel", "Rio de Janeiro", "RJ", "21715-280");
            Assert.Throws<ExEnderecoExistente>(delegate { esperado.AdicionarEndereco(TipoLogradouro.Rua, "Maria Carvalho", "80", "", "Padre Miguel", "Rio de Janeiro", "RJ", "21715-280"); });
        }

        [Test]
        public void IncluirTelefoneExistente()
        {
            PessoaFisica PessoaFisica = new PessoaFisica();
            PessoaFisica.Nome = "Glebson Lima";
            PessoaFisica.CPF = "0003";
            PessoaFisica.Renda = 10000;
            PessoaFisica.AdicionarTelefone(TipoTelefone.Celular, "021", "9396-7487");
            Assert.Throws<ExTelefoneExistente>(delegate { PessoaFisica.AdicionarTelefone(TipoTelefone.Celular, "021", "9396-7487"); });
        }

        [Test]
        public void ExcluirTelefone()
        {
            PessoaFisica PessoaFisica = new PessoaFisica();
            PessoaFisica = new PessoaFisica();
            PessoaFisica.Nome = "Glebson Lima";
            PessoaFisica.CPF = "0004";
            PessoaFisica.Renda = 10000;
            PessoaFisica.AdicionarTelefone(TipoTelefone.Residencial, "021", "2928-0923");
            PessoaFisica.ExcluirTelefone("021", "2928-0923");
            Int32 atual = 0;
            Int32 esperado = PessoaFisica.Telefones.Count();
            Assert.AreEqual(esperado, atual);
        }

        [Test]
        public void ExcluirTelefoneInexistente()
        {
            PessoaFisica PessoaFisica = new PessoaFisica();
            PessoaFisica = new PessoaFisica();
            PessoaFisica.Nome = "Glebson Lima";
            PessoaFisica.CPF = "0005";
            PessoaFisica.Renda = 10000;
            Assert.Throws<ExTelefoneInexistente>(delegate { PessoaFisica.ExcluirTelefone("021", "8720-0012"); });
        }

        [Test]
        public void ExcluirEndereco()
        {
            PessoaFisica PessoaFisica = new PessoaFisica();
            PessoaFisica.Nome = "Glebson Lima";
            PessoaFisica.CPF = "0006";
            PessoaFisica.Renda = 185000;
            PessoaFisica.AdicionarEndereco(TipoLogradouro.Avenida, "das Americas", "500", "sala 240", "Barra da Tijuca", "Rio de Janeiro", "RJ", "81547-505");
            PessoaFisica.ExcluirEndereco(TipoLogradouro.Avenida, "das Americas", "500", "sala 240", "Barra da Tijuca", "Rio de Janeiro", "RJ", "81547-505");
            Int32 esperado = PessoaFisica.Enderecos.Count();
            Int32 atual = 0;
            Assert.AreEqual(esperado, atual);
        }

        [Test]
        public void ExcluirEnderecoInexistente()
        {
            PessoaFisica PessoaFisica = new PessoaFisica();
            PessoaFisica = new PessoaFisica();
            PessoaFisica.Nome = "Glebson Lima";
            PessoaFisica.CPF = "0007";
            PessoaFisica.Renda = 10000;
            Assert.Throws<ExEnderecoInexistente>(delegate
            {
                PessoaFisica.ExcluirEndereco(TipoLogradouro.Avenida,
                    "das Americas", "500", "sala 240", "Barra da Tijuca", "Rio de Janeiro", "RJ", "81547-505");
            });
        }
    }
}
