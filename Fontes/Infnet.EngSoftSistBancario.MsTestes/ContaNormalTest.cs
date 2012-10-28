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
    public class ContaNormalTest
    {


        [TestMethod()]
        public void ClienteNormalContaTest()
        {
           
            Normal target = new Normal(); 

            Cliente esperado = new Cliente(); 
            esperado.Nome = "Glebson";
            Cliente retornado;
            target.Nome = esperado;
            retornado = target.Nome;
            Assert.AreEqual(esperado, retornado);

        }

        [TestMethod()]
        public void ContaNormalContaTest()
        {
            Normal target = new Normal();
            int esperado = int.Parse("030");
            int retornado;
            target.NumeroDaconta = esperado;
            retornado = target.NumeroDaconta;
            Assert.AreEqual(esperado, retornado);
        }

        [TestMethod()]
        public void TaxaNormalContaTest()
        {
            Normal target = new Normal();
            decimal esperado = decimal.Parse("10.00");
            decimal retornado;
            target.Tarifa = esperado;
            retornado = target.Tarifa;
            Assert.AreEqual(esperado, retornado);
        }

        [TestMethod()]
        public void StatusNormalContaTest()
        {
            Normal target = new Normal();
            bool esperado = true;
            bool retornado;
            target.statusDaConta = esperado;
            retornado = target.statusDaConta;
            target.setBloqueado(retornado);
            Assert.AreEqual(esperado, retornado);
 
        }




       
    

    }
}
