using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Infnet.EngSoftSistBancario.Modelo;
using System.Reflection;

namespace Infnet.EngSoftSistBancario.Testes
{
    public class ClienteTest
    {
        
        public void ObterAtributos()
        {
            PessoaFisica pessoafisica = new PessoaFisica();
            Int32 atual = pessoafisica.GetType().GetProperties().Count();
            Int32 esperado = 7;
            Assert.AreEqual(esperado, atual);
        }

        
        public void ObterMetodos()
        {
            PessoaFisica pessoafisica = new PessoaFisica();
            Int32 atual = pessoafisica.GetType().GetMethods().Count();
            Int32 esperado = 10;
            Assert.AreEqual(esperado, atual);
        }

        
        public void AtribuirValorEmNome()
        {
            PessoaFisica pessoafisica = new PessoaFisica();
            String esperado = "Taty";
            String atual = null;
            PropertyInfo[] campos = pessoafisica.GetType().GetProperties();



            pessoafisica.Nome = "Carlos";


            foreach (PropertyInfo campo in campos)
            {
                if (campo.Name == "Nome")
                {
                    campo.SetValue(pessoafisica, "Taty", null);
                    atual = campo.GetValue(pessoafisica, null).ToString();
                }
            }

            Assert.AreEqual(esperado, atual);
        }

        public void IncluirTest()
        {

        }
    
    }
}
