using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Infnet.EngSoftSistBancario.Modelo.ContaCorrente;
using Infnet.EngSoftSistBancario.Modelo;

namespace Infnet.EngSoftSistBancario.MsTestes
{
    [TestClass]
    public class ContaEspecialTest
  {

      private Especial especial;
      public ContaEspecialTest()
      {

          especial = new Especial();
      }


      [TestMethod()]
      public void ClienteEspecialContaTest()
      {

          Especial target = new Especial();

          Cliente esperado = new Cliente();
          esperado.Nome = "Glebson";
          Cliente retornado;
          target.Nome = esperado;
          retornado = target.Nome;
          Assert.AreEqual(esperado, retornado);

      }

      [TestMethod()]
      public void ContaEspecialContaTest()
      {
          Especial target = new Especial();
          int esperado = int.Parse("0305824");
          int retornado;
          target.NumeroDaconta = esperado;
          retornado = target.NumeroDaconta;
          Assert.AreEqual(esperado, retornado);
      }

      [TestMethod()]
      public void TaxaEspecialContaTest()
      {
          Especial target = new Especial();
          decimal esperado = decimal.Parse("350.00");
          decimal retornado;
          target.Tarifa = esperado;
          retornado = target.Tarifa;
          Assert.AreEqual(esperado, retornado);
      }

      [TestMethod()]
      public void StatusEspecialContaTest()
      {
          Especial target = new Especial();
          bool esperado = true;
          bool retornado;
          target.statusDaConta = esperado;
          retornado = target.statusDaConta;
          target.setBloqueado(retornado);
          Assert.AreEqual(esperado, retornado);

      }
   
        
        [TestMethod()]
      public void TestarLimiteDoCliente()
      {
          Especial target = new Especial();
          target.Limite = 500;
          bool esperado = true;
          bool retornado = target.TemLimite();
          Assert.AreEqual(esperado, retornado);
      }

    }
}
