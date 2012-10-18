using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inf.EngSoftSistBancario.Modelo.Banco
{
     public abstract class Banco
    {
        public string cliente { get; set; }
         public inf.EngSoftSistBancario.Modelo.Clientes.Cliente Cliente
         {
             get
             {
                throw new System.NotImplementedException();
             }
             set
             {
             }
         }

         internal ServicoAnaliseClientePotencial ServicoAnaliseClientePotencial
         {
             get
             {
                 throw new System.NotImplementedException();
             }
             set
             {
             }
         }

         internal OrdemJuridica OrdemJuridica
         {
             get
             {
                 throw new System.NotImplementedException();
             }
             set
             {
             }
         }

         public ContaCorrente ContaCorrente
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
