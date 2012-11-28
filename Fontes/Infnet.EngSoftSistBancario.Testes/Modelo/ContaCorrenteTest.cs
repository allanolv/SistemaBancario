using System;
using System.Collections.Generic;
using NUnit.Framework;
using Infnet.EngSoftSistBancario.Modelo;
using Infnet.EngSoftSistBancario.Repositorio;

namespace Infnet.EngSoftSistBancario.Testes
{
    
    
    /// <summary>
    ///This is a test class for ContaCorrenteTest and is intended
    ///to contain all ContaCorrenteTest Unit Tests
    ///</summary>
    [TestFixture]
    public class ContaCorrenteTest
    {

        [Test]
        public void CriarContaCorrente()
        {
            RepositorioContaCorrente rContaCorrente = RepositorioContaCorrente.Instancia();
            PessoaFisica pessoaFisica = new PessoaFisica();
            pessoaFisica.Nome = "Poliana Corbo";
            pessoaFisica.CPF = "01234";
            ContaCorrente contaCorrente = rContaCorrente.CriarContaCorrente(pessoaFisica,"0312",11);
            Assert.IsNotNull(contaCorrente);
        }

        [Test]
        public void CriarContaCorrenteEspecial()
        {
            RepositorioContaCorrente rContaCorrente = RepositorioContaCorrente.Instancia();
            PessoaFisica pessoaFisica = new PessoaFisica();
            pessoaFisica.Nome = "Ronaldo Corbo";
            pessoaFisica.CPF = "01235";
            ContaCorrenteEspecial contaCorrenteEspecial = rContaCorrente.CriarContaCorrente(pessoaFisica, "0312", 11, 100);
            Assert.IsNotNull(contaCorrenteEspecial);
        }

     
        [Test]
        public void EncerrarContaCorrente() {

            PessoaFisica pessoaFisica = new PessoaFisica();
            ContaCorrente contaCorrente = new ContaCorrente ();
            pessoaFisica.Nome = "Glebson Lima";
            contaCorrente.Titular = pessoaFisica;
            contaCorrente.Agencia = "031";
            contaCorrente.Numero = "8547212";
            contaCorrente.Tarifa = Decimal.Parse("15,00");  
            contaCorrente.Encerrar();
            StatusContaCorrente atual = contaCorrente.Status;
            StatusContaCorrente esperado = StatusContaCorrente.Encerrada;
            Assert.AreEqual(esperado, atual);

        
        }

        [Test]
        public void BloquearContaCorrente()
        {

            PessoaFisica pessoaFisica = new PessoaFisica();
            ContaCorrente contaCorrente = new ContaCorrente();
            pessoaFisica.Nome = "Ana Carolina";
            contaCorrente.Titular = pessoaFisica;
            contaCorrente.Agencia = "068";
            contaCorrente.Numero = "8525691";
            contaCorrente.Tarifa = Decimal.Parse("35,00");
            contaCorrente.Bloquear();
            StatusContaCorrente atual = contaCorrente.Status;
            StatusContaCorrente esperado = StatusContaCorrente.Bloqueada;
            Assert.AreEqual(esperado, atual);


        }

        [Test]
        public void DesbloquearContaCorrente()
        {

            PessoaFisica pessoaFisica = new PessoaFisica();
            ContaCorrente contaCorrente = new ContaCorrente();
            pessoaFisica.Nome = "Allan Oliveira";
            contaCorrente.Titular = pessoaFisica;
            contaCorrente.Agencia = "052";
            contaCorrente.Numero = "3526980";
            contaCorrente.Tarifa = Decimal.Parse("20,00");
            contaCorrente.Desbloquear();
            StatusContaCorrente atual = contaCorrente.Status;
            StatusContaCorrente esperado = StatusContaCorrente.Ativa;
            Assert.AreEqual(esperado, atual);

        }

      }
}
