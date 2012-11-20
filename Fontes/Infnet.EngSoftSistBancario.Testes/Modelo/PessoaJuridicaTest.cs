using NUnit.Framework;
using System;
using Infnet.EngSoftSistBancario.Modelo;
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
        public void IncluirTelefonesTest()
        {
            esperado = new PessoaJuridica();
            esperado.Nome = "Glebson Lima";
            esperado.CNPJ = "35.380.399/0001-88";
            esperado.Receita = 10000;
            esperado.AdicionarTelefone(TipoTelefone.Celular, "021", "9396-7487");
            Telefone atual = esperado.Telefones.Where(t => t.DDD == "021" && t.Numero == "9396-7487").FirstOrDefault();
            Assert.Contains(atual, esperado.Telefones);
        }
    }
}
