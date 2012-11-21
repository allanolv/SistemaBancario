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

        public PessoaFisica IncluirUmClientePessoaFisica(String pCPF)
        {
            PessoaFisica pessoaFisica = new PessoaFisica();
            pessoaFisica.Nome = "CARLOS HENRIQUE MEIRELES CORBO";
            pessoaFisica.Renda = 1000;
            pessoaFisica.CPF = pCPF;
            pessoaFisica.AdicionarTelefone(TipoTelefone.Celular,
                "021",
                "8890-0092");
            pessoaFisica.AdicionarEndereco(TipoLogradouro.Rua,
                "Dona Alice", "S/N",
                "Lt. 39 Qd.22",
                "Vila Tiradentes",
                "São João de Meriti",
                "RJ",
                "25525-290");

            repositorioCliente.Inserir<PessoaFisica>(pessoaFisica);
            return pessoaFisica;
        }

        public PessoaJuridica IncluirUmClientePessoaJuridica(String pCNPJ)
        {
            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.Nome = "Instituto Infnet";
            pessoaJuridica.Receita = 230000;
            pessoaJuridica.CNPJ = pCNPJ;
            pessoaJuridica.AdicionarTelefone(TipoTelefone.Comercial, "021", "2122-8800");
            pessoaJuridica.AdicionarEndereco(TipoLogradouro.Rua,
                "Rua São José",
                "90",
                "2o piso",
                "Centro",
                "Rio de Janeiro",
                "RJ",
                "20010-020");

            repositorioCliente.Inserir<PessoaJuridica>(pessoaJuridica);
            return pessoaJuridica;
        }

        public void IncluirClientes()
        {
            /* Inclusão do cliente 1 */
            PessoaFisica pessoaFisica = new PessoaFisica();
            pessoaFisica.Nome = "CARLOS HENRIQUE MEIRELES CORBO";
            pessoaFisica.Renda = 1000;
            pessoaFisica.CPF = "001";
            pessoaFisica.AdicionarTelefone(TipoTelefone.Celular,
                "021",
                "8890-0092");
            pessoaFisica.AdicionarEndereco(TipoLogradouro.Rua,
                "Dona Alice", "S/N",
                "Lt. 39 Qd.22",
                "Vila Tiradentes",
                "São João de Meriti",
                "RJ",
                "25525-290");

            repositorioCliente.Inserir<PessoaFisica>(pessoaFisica);

            /* Inclusão do cliente 2 */

            pessoaFisica = new PessoaFisica();
            pessoaFisica.Nome = "TATIANE MOREIRA DA SILVA CORBO";
            pessoaFisica.Renda = 800;
            pessoaFisica.CPF = "002";
            pessoaFisica.AdicionarTelefone(TipoTelefone.Residencial,
                "021",
                "2121-1233");
            pessoaFisica.AdicionarEndereco(TipoLogradouro.Rua,
                "Rua Maria Carvalho", "80",
                "Casa 1",
                "Padre Miguel",
                "Rio de Janeiro",
                "RJ",
                "21715-280");

            repositorioCliente.Inserir<PessoaFisica>(pessoaFisica);

            /* Inclusão do cliente 3 */
            pessoaFisica = new PessoaFisica();
            pessoaFisica.Nome = "GABRIELA MOREIRA DA SILVA";
            pessoaFisica.Renda = 2500;
            pessoaFisica.CPF = "003";
            pessoaFisica.AdicionarTelefone(TipoTelefone.Residencial,
                "021",
                "2565-2928");
            pessoaFisica.AdicionarEndereco(TipoLogradouro.Travessa,
                "Porto Alegre", "102",
                "Casa 7",
                "Santa Cruz da Serra",
                "Duque de Caxias",
                "RJ",
                "25232-220");

            repositorioCliente.Inserir<PessoaFisica>(pessoaFisica);
            /**************************************************/
            /* Inclusão do cliente 4 */
            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.Nome = "Instituto Infnet";
            pessoaJuridica.Receita = 230000;
            pessoaJuridica.CNPJ = "0001";
            pessoaJuridica.AdicionarTelefone(TipoTelefone.Comercial, "021", "2122-8800");
            pessoaJuridica.AdicionarEndereco(TipoLogradouro.Rua,
                "Rua São José",
                "90",
                "2o piso",
                "Centro",
                "Rio de Janeiro",
                "RJ",
                "20010-020");

            repositorioCliente.Inserir<PessoaJuridica>(pessoaJuridica);

            /* Inclusão do cliente 5 */
            pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.Nome = "Universo Calçados LTDA";
            pessoaJuridica.Receita = 210000;
            pessoaJuridica.CNPJ = "0002";
            pessoaJuridica.AdicionarTelefone(TipoTelefone.Comercial, "021", "3192-1209");
            pessoaJuridica.AdicionarEndereco(TipoLogradouro.Rua,
                "Rua Antonio Rabelo",
                "312",
                "Lj 05",
                "Centro",
                "Belford Roxo",
                "RJ",
                "25010-020");

            repositorioCliente.Inserir<PessoaJuridica>(pessoaJuridica);
            /**********************************************************/
        }

        [Test]
        public void TestarInstanciaUnica()
        {
            RepositorioClientes repositorioCliente1 = repositorioCliente;
            RepositorioClientes repositorioCliente2 = RepositorioClientes.Instancia();

            Assert.AreSame(repositorioCliente1, repositorioCliente2);
        }

        [Test]
        public void InclusaoClientePessoaFisica()
        {
            PessoaFisica esperado = IncluirUmClientePessoaFisica("101");
            PessoaFisica atual = repositorioCliente.ObterCPF("101");
            Assert.AreSame(esperado, atual);
            repositorioCliente.DesativarCliente(esperado);
        }
        
        [Test]
        public void IncluirClientePessoaJuridica()
        {
            /* Inclusão do cliente 4 */
            PessoaJuridica esperado = IncluirUmClientePessoaJuridica("1001");
            PessoaJuridica atual = repositorioCliente.ObterCNPJ("1001");
            Assert.AreSame(esperado, atual);
            repositorioCliente.DesativarCliente(esperado);
        }

        [Test]
        public void AtivarCliente()
        {
            PessoaFisica esperado1 = IncluirUmClientePessoaFisica("201");
            repositorioCliente.AtivarCliente(esperado1);
            Assert.AreEqual(StatusCliente.Ativo, esperado1.Status);

            PessoaJuridica esperado2 = IncluirUmClientePessoaJuridica("2001");
            repositorioCliente.AtivarCliente(esperado2);
            Assert.AreEqual(StatusCliente.Ativo, esperado2.Status);
            repositorioCliente.DesativarCliente(esperado1);
            repositorioCliente.DesativarCliente(esperado2);
        }
        
        [Test]
        public void DesativarCliente()
        {
            PessoaFisica esperado1 = IncluirUmClientePessoaFisica("301");
            repositorioCliente.AtivarCliente(esperado1);
            repositorioCliente.DesativarCliente(esperado1);
            Assert.AreEqual(StatusCliente.Inativo, esperado1.Status);

            PessoaJuridica esperado2 = IncluirUmClientePessoaJuridica("3001");
            repositorioCliente.AtivarCliente(esperado2);
            repositorioCliente.DesativarCliente(esperado2);
            Assert.AreEqual(StatusCliente.Inativo, esperado2.Status);
        }

        [Test]
        public void ListarClienteAtivos()
        {
            Int32 esperado = 0;
            Int32 atual = 1;

            IncluirUmClientePessoaFisica("401");
            esperado = repositorioCliente.ListarClientesAtivos<PessoaFisica>().Count();
            Assert.AreEqual(esperado, atual);

            IncluirUmClientePessoaJuridica("4001");
            esperado = repositorioCliente.ListarClientesAtivos<PessoaJuridica>().Count();
            Assert.AreEqual(esperado, atual);

            esperado = repositorioCliente.ListarClientesAtivos<Cliente>().Count();
            atual = 2;
            Assert.AreEqual(esperado, atual);
            List<Cliente> listaClienteAtivos = repositorioCliente.ListarClientesAtivos<Cliente>();

            foreach (Cliente cliente in listaClienteAtivos)
            {
                repositorioCliente.DesativarCliente(cliente);
            }
        }

        [Test]
        public void ListarClientePotencial()
        {
            IncluirClientes();

            Int32 esperado = repositorioCliente.ListarClientesPotencial<Cliente>().Count();
            Int32 atual = 5;
            Assert.AreEqual(esperado, atual);

            esperado = repositorioCliente.ListarClientesPotencial<PessoaFisica>().Count();
            atual = 3;
            Assert.AreEqual(esperado, atual);

            esperado = repositorioCliente.ListarClientesPotencial<PessoaJuridica>().Count();
            atual = 2;
            Assert.AreEqual(esperado, atual);

        }

        public void AlterarCliente()
        {


        }
    
    }
}
