﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infnet.EngSoftSistBancario.Modelo;
using Infnet.EngSoftSistBancario.Repositorio;
using NUnit.Framework;

namespace Infnet.EngSoftSistBancario.Testes
{
    [TestFixture]
    public class RepositorioClientePessoaJuridicaTest
    {
        RepositorioClientePessoaJuridica rClientePessoaJuridica;

        public RepositorioClientePessoaJuridicaTest()
        {
            rClientePessoaJuridica = RepositorioClientePessoaJuridica.Instancia();
        }

        public PessoaJuridica IncluirUmCliente(String pCNPJ)
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

            rClientePessoaJuridica.Inserir(pessoaJuridica);
            return pessoaJuridica;
        }

        [Test]
        public void Incluir()
        {
            PessoaJuridica esperado = IncluirUmCliente("0001");
            PessoaJuridica atual = rClientePessoaJuridica.ObterCNPJ("0001");
            Assert.AreSame(esperado, atual);
        }

        [Test]
        public void Alterar()
        {
            IncluirUmCliente("0002");
            PessoaJuridica atual = ((PessoaJuridica)rClientePessoaJuridica.ObterCNPJ("0002").Clone());
            atual.Nome = "PUC Rio";
            rClientePessoaJuridica.Alterar(atual);
            PessoaJuridica esperado = ((PessoaJuridica)rClientePessoaJuridica.ObterCNPJ("0002").Clone());
            Assert.AreEqual(esperado.Nome, atual.Nome);
        }
    }
}
