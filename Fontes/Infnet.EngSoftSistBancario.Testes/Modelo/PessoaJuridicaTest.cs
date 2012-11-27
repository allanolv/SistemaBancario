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
<<<<<<< HEAD
        PessoaJuridica pessoaJuridica;

        [Test]
        public void AtivarCliente()
        {
            pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.Nome = "Glebson Lima";
=======
        PessoaJuridica esperado;

        [Test]
        public void AtivarClienteTest()
        {
            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.Nome = "Carlos";
>>>>>>> origin/CarlosRepositorioCliente
            pessoaJuridica.Ativar();
            StatusCliente atual = pessoaJuridica.Status;
            StatusCliente esperado = StatusCliente.Ativo;
            Assert.AreEqual(esperado, atual);
        }

<<<<<<< HEAD
        [Test]
        public void DesativarCliente()
        {
            pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.Nome = "Glebson Lima";
            pessoaJuridica.CNPJ = "36.874.556/0432-67";
            pessoaJuridica.Receita = 10000;
            Assert.Throws<ExMudarStatusCliente>(delegate { pessoaJuridica.Desativar(); });

        }

=======
>>>>>>> origin/CarlosRepositorioCliente
        [Test]
        public void InfoBasicoTest()
        {
            List<PessoaJuridica> lista = new List<PessoaJuridica>();
            pessoaJuridica = new PessoaJuridica { Nome = "Glebson Lima", CNPJ = "36.874.556/0432-67", Receita = 2000 };
            lista.Add(pessoaJuridica);
            List<PessoaJuridica> esperado = lista;
            List<PessoaJuridica> atual;
            atual = esperado.ToList();
            Assert.AreEqual(esperado, atual);


        }

       
        [Test]
        public void EnderecosTest()
        {
            pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.Nome = "Glebson Lima";
            pessoaJuridica.CNPJ = "36.874.556/0432-67";
            pessoaJuridica.Receita = 185000;
            pessoaJuridica.AdicionarEndereco(TipoLogradouro.Avenida, "das Americas", "500", "sala 240", "Barra da Tijuca", "Rio de Janeiro", "RJ", "81547-505");
            Endereco atual = pessoaJuridica.Enderecos.Where(e => e.CEP == "81547-505").FirstOrDefault();
            Assert.Contains(atual, pessoaJuridica.Enderecos);
        }

        [Test]
        public void IncluirEnderecoExistente()
        {
            pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.Nome = "Glebson Lima";
            pessoaJuridica.CNPJ = "36.874.556/0432-67";
            pessoaJuridica.Receita = 185000;
            pessoaJuridica.AdicionarEndereco(TipoLogradouro.Rua, "Maria Carvalho", "80", "", "Padre Miguel", "Rio de Janeiro", "RJ", "21715-280");
            Assert.Throws<ExEnderecoExistente>(delegate { pessoaJuridica.AdicionarEndereco(TipoLogradouro.Rua, "Maria Carvalho", "80", "", "Padre Miguel", "Rio de Janeiro", "RJ", "21715-280"); });
        }

        [Test]
        public void IncluirTelefoneExistente()
        {
            pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.Nome = "Glebson Lima";
            pessoaJuridica.CNPJ = "36.874.556/0432-67";
            pessoaJuridica.Receita = 10000;
            pessoaJuridica.AdicionarTelefone(TipoTelefone.Celular, "021", "9396-7487");
            Assert.Throws<ExTelefoneExistente>(delegate { pessoaJuridica.AdicionarTelefone(TipoTelefone.Celular, "021", "9396-7487"); });
        }

        [Test]
        public void ExcluirTelefone()
        {
            pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.Nome = "Glebson Lima";
            pessoaJuridica.CNPJ = "36.874.556/0432-67";
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
            pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.Nome = "Glebson Lima";
            pessoaJuridica.CNPJ = "36.874.556/0432-67";
            pessoaJuridica.Receita = 10000;
            Assert.Throws<ExTelefoneInexistente>(delegate { pessoaJuridica.ExcluirTelefone("021", "8720-0012"); });
        }

        [Test]
        public void ExcluirEndereco()
        {
            pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.Nome = "Glebson Lima";
            pessoaJuridica.CNPJ = "36.874.556/0432-67";
            pessoaJuridica.Receita = 185000;
            pessoaJuridica.AdicionarEndereco(TipoLogradouro.Avenida, "das Americas", "500", "sala 240", "Barra da Tijuca", "Rio de Janeiro", "RJ", "81547-505");
            pessoaJuridica.ExcluirEndereco(TipoLogradouro.Avenida, "das Americas", "500", "sala 240", "Barra da Tijuca", "Rio de Janeiro", "RJ", "81547-505");
            Int32 esperado = pessoaJuridica.Enderecos.Count();
            Int32 atual = 0;
            Assert.AreEqual(esperado, atual);
        }

        [Test]
        public void TelefonesTest()
        {
            pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.Nome = "Glebson Lima";
            pessoaJuridica.CNPJ = "36.874.556/0432-67";
            pessoaJuridica.Receita = 2000;
            pessoaJuridica.AdicionarTelefone(TipoTelefone.Celular, "021", "8587-7425");
            Telefone atual = pessoaJuridica.Telefones.Where(t => t.Numero == "8587-7425").FirstOrDefault();
            Assert.Contains(atual, pessoaJuridica.Telefones);
        }


        [Test]
        public void ExcluirEnderecoInexistente()
        {
            pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.Nome = "Glebson Lima";
            pessoaJuridica.CNPJ = "36.874.556/0432-67";
            pessoaJuridica.Receita = 10000;
            Assert.Throws<ExEnderecoInexistente>(delegate
            {
                pessoaJuridica.ExcluirEndereco(TipoLogradouro.Avenida,
                    "das Americas", "500", "sala 240", "Barra da Tijuca", "Rio de Janeiro", "RJ", "81547-505");
            });
        }

    }
}
