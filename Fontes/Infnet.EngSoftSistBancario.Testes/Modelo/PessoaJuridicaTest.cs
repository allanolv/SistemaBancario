using NUnit.Framework;
using System;
using Infnet.EngSoftSistBancario.Modelo;
using Infnet.EngSoftSistBancario.Modelo.Excecoes;
using System.Collections.Generic;
using System.Linq;

namespace Infnet.EngSoftSistBancario.Testes
{
    /// <summary>
    ///This is a test class for PessoaJuridicaTest and is intended
    ///to contain all PessoaJuridicaTest Unit Tests
    ///</summary>
    [TestFixture]
    public class PessoaJuridicaTest
    {
        PessoaJuridica esperado;

      

        [Test]
        public void InfoBasicoTest()
        {
            List<PessoaJuridica> lista = new List<PessoaJuridica>();
            PessoaJuridica Tel = new PessoaJuridica { Nome = "Glebson Lima", CNPJ = "871.852.323/02", Receita = 2000 };
            lista.Add(Tel);
            List<PessoaJuridica> esperado = lista;
            List<PessoaJuridica> atual;
            atual = esperado.ToList();
            Assert.AreEqual(esperado, atual);


        }

        [Test]
        public void IncluirTelefonesTest()
        {
            esperado = new PessoaJuridica();
            esperado.Nome = "Glebson Lima";
            esperado.CNPJ = "0001";
            esperado.Receita = 10000;
            esperado.AdicionarTelefone(TipoTelefone.Celular, "021", "9396-7487");
            Telefone atual = esperado.Telefones.Where(t => t.Numero == "9396-7487").FirstOrDefault();
            Assert.Contains(atual, esperado.Telefones);
        }

        [Test]
        public void IncluirEnderecosTest()
        {
            esperado = new PessoaJuridica();
            esperado.Nome = "Glebson Lima";
            esperado.CNPJ = "0002";
            esperado.Receita = 185000;
            esperado.AdicionarEndereco(TipoLogradouro.Avenida, "das Americas", "500", "sala 240", "Barra da Tijuca", "Rio de Janeiro", "RJ", "81547-505");
            Endereco atual = esperado.Enderecos.Where(e => e.CEP == "81547-505").FirstOrDefault();  
            Assert.Contains(atual, esperado.Enderecos);
        }
        [Test]
        public void IncluirEnderecoExistente()
        {
            esperado = new PessoaJuridica();
            esperado.Nome = "Glebson Lima";
            esperado.CNPJ = "0002";
            esperado.Receita = 185000;
            esperado.AdicionarEndereco(TipoLogradouro.Rua, "Maria Carvalho", "80", "", "Padre Miguel", "Rio de Janeiro", "RJ", "21715-280");
            Assert.Throws<ExEnderecoExistente>(delegate { esperado.AdicionarEndereco(TipoLogradouro.Rua, "Maria Carvalho", "80", "", "Padre Miguel", "Rio de Janeiro", "RJ", "21715-280"); });
        }

        [Test]
        public void IncluirTelefoneExistente()
        {
            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.Nome = "Glebson Lima";
            pessoaJuridica.CNPJ = "0003";
            pessoaJuridica.Receita = 10000;
            pessoaJuridica.AdicionarTelefone(TipoTelefone.Celular, "021", "9396-7487");
            Assert.Throws<ExTelefoneExistente>(delegate { pessoaJuridica.AdicionarTelefone(TipoTelefone.Celular, "021", "9396-7487"); });
        }

        [Test]
        public void ExcluirTelefone()
        {
            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.Nome = "Glebson Lima";
            pessoaJuridica.CNPJ = "0004";
            pessoaJuridica.Receita = 10000;
            pessoaJuridica.AdicionarTelefone(TipoTelefone.Residencial, "021", "2928-0923");
            pessoaJuridica.ExcluirTelefone("021", "2928-0923");
            Int32 atual = 0;
            Int32 esperado = pessoaJuridica.Telefones.Count();
            Assert.AreEqual(esperado, atual);
        }

        [Test]
        public void ExcluirTelefoneInexistente()
        {
            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.Nome = "Glebson Lima";
            pessoaJuridica.CNPJ = "0005";
            pessoaJuridica.Receita = 10000;
            Assert.Throws<ExTelefoneInexistente>(delegate { pessoaJuridica.ExcluirTelefone("021", "8720-0012"); });
        }

        [Test]
        public void ExcluirEndereco()
        {
            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.Nome = "Glebson Lima";
            pessoaJuridica.CNPJ = "0006";
            pessoaJuridica.Receita = 185000;
            pessoaJuridica.AdicionarEndereco(TipoLogradouro.Avenida, "das Americas", "500", "sala 240", "Barra da Tijuca", "Rio de Janeiro", "RJ", "81547-505");
            pessoaJuridica.ExcluirEndereco(TipoLogradouro.Avenida, "das Americas", "500", "sala 240", "Barra da Tijuca", "Rio de Janeiro", "RJ", "81547-505");
            Int32 esperado = pessoaJuridica.Enderecos.Count();
            Int32 atual = 0;
            Assert.AreEqual(esperado, atual);
        }

        [Test]
        public void ExcluirEnderecoInexistente()
        {
            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.Nome = "Glebson Lima";
            pessoaJuridica.CNPJ = "0007";
            pessoaJuridica.Receita = 10000;
            Assert.Throws<ExEnderecoInexistente>(delegate { pessoaJuridica.ExcluirEndereco(TipoLogradouro.Avenida, 
                "das Americas", "500", "sala 240", "Barra da Tijuca", "Rio de Janeiro", "RJ", "81547-505"); });
        }

    }
}
