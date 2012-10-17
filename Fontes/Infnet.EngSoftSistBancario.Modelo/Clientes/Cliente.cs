using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inf.EngSoftSistBancario.Modelo.Clientes
{
   public abstract class Cliente
    {
       private string nome;
        public string Nome { 
            get{return nome;}
            set{nome = value;}
        }
        public List<Endereco> Enderecos { get; set; }
        public List<Telefone> Telefones { get; set; }

        public inf.EngSoftSistBancario.Modelo.Banco.Banco Banco
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public inf.EngSoftSistBancario.Modelo.TransacoesBancarias.TransacaoBancaria TransacaoBancaria
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public inf.EngSoftSistBancario.Modelo.Banco.ContaCorrente ContaCorrente
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
