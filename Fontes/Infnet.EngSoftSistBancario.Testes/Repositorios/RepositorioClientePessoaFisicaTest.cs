﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Infnet.EngSoftSistBancario.Modelo;
using Infnet.EngSoftSistBancario.Repositorio;

namespace Infnet.EngSoftSistBancario.Testes
{
    [TestFixture]
    public class RepositorioClientePessoaFisicaTest
    {
        RepositorioClientePessoaFisica rClientePessoaFisica;

        public RepositorioClientePessoaFisicaTest()
        {
            rClientePessoaFisica = RepositorioClientePessoaFisica.Instancia();
        }

        public PessoaFisica IncluirCliente(String pCPF)
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

            rClientePessoaFisica.Inserir(pessoaFisica);
            return pessoaFisica;

        }

        [Test]
        public void Incluir()
        {
            PessoaFisica esperado = IncluirCliente("001");
            PessoaFisica atual = rClientePessoaFisica.ObterCPF("001");
            Assert.AreSame(esperado, atual);
        }

        [Test]
        public void Alterar()
        {
            IncluirCliente("002");
            PessoaFisica atual = ((PessoaFisica) rClientePessoaFisica.ObterCPF("002").Clone());
            atual.Nome = "TATIANE MOREIRA DA SILVA CORBO";
            rClientePessoaFisica.Alterar(atual);
            PessoaFisica esperado = ((PessoaFisica)rClientePessoaFisica.ObterCPF("002").Clone());
            Assert.AreEqual(esperado.Nome, atual.Nome);
        }
    }
}
