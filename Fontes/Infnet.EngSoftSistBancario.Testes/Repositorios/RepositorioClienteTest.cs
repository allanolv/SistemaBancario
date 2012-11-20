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
    /// Summary description for RepositorioDeClienteTest
    /// </summary>
    [TestFixture]
    public class RepositorioClienteTest
    {
        RepositorioClientes repositorioCliente;

        public RepositorioClienteTest()
        {
            repositorioCliente = RepositorioClientes.Instancia();
        }

        [Test]
        public void TestarInstanciaUnica()
        {
            RepositorioClientes repositorioCliente2 = RepositorioClientes.Instancia();

            Assert.AreSame(repositorioCliente, repositorioCliente2);
        }

        [Test]
        public void IncluirPessoaFisica()
        {
            PessoaFisica expected = new PessoaFisica();
            expected.Nome = "CARLOS HENRIQUE MEIRELES CORBO";
            expected.Renda = 1000;
            expected.CPF = "123";
            expected.AdicionarTelefone(TipoTelefone.Residencial,
                "021",
                "8890-0092");
            expected.AdicionarEndereco(TipoLogradouro.Rua,
                "Dona Alice","S/N",
                "Lt. 39 Qd.22",
                "Vila Tiradentes",
                "São João de Meriti",
                "RJ",
                "25525-290");
            repositorioCliente.Inserir(expected);
            
            PessoaFisica actual = (repositorioCliente.ObterCPF("123") as PessoaFisica);

            Assert.AreEqual(expected, actual);
        }

        public void IncluirPessoaJuridica()
        {
            /* Fazer o mesmo que o método de teste */
        }

        public void AtivarCliente()
        {
            // Criar um objeto qualquer;
            // Mandar incluir no repositório;
            // Mandar ativar pelo repositório;
            // Recupear o mesmo objeto incluído passo 1;
            // Verifica através do assert se o mesmo está ativado;
        }

        public void DesativarCliente()
        {
            PessoaFisica pessoaFisica = repositorioCliente.ObterCPF("123");
            repositorioCliente.DesativarCliente<PessoaFisica>(pessoaFisica);
            Assert.AreEqual(StatusCliente.Inativo, pessoaFisica.Status);
        }

        public void AdicionarTelefone()
        {
            // Adicionar alguns enderecos;
            // E verificar se os endereços adicionados estão no objeto cliente;
        }

        public void AdicionarEndereco()
        {

        }


    
    }
}
