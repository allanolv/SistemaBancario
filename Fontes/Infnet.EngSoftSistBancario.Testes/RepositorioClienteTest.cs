using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Infnet.EngSoftSistBancario.Modelo;
using Infnet.EngSoftSistBancario.Repositorio;
using NUnit.Framework;

namespace Infnet.EngSoftSistBancario.MsTestes
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
            PessoaFisica pessoaFisica = new PessoaFisica();
            pessoaFisica.Nome = "CARLOS HENRIQUE MEIRELES CORBO";
            pessoaFisica.Renda = 1000;
            //pessoaFisica.AdionarTelefone(new Telefone("021","8890-0092",

            /* Adicionar um cliente e tentar recuperar depois verificando através da classe estática Assert se o cliente recuperado 
             * é mesmo que foi inserido */
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
