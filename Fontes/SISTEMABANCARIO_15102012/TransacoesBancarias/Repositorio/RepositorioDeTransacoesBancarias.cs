using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inf.EngSoftSistBancario.Modelo.TransacoesBancarias.Repositorio
{
  public  class RepositorioDeTransacoesBancarias
    {
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
  
        public Boolean GravarSaque(Saque pSaque)
        {
            throw new NotImplementedException();
        }

        public Boolean GravarTransferencia(Transferencia pTransferencia)
        {
            throw new NotImplementedException();
        }

        public Boolean GravarDeposito(Deposito pDeposito)
        {
            throw new NotImplementedException();
        }

      //Comprovante nao pode conhecer RepositorioTranssacoesBancarias
     /*   public Comprovante EmitirComprovante(TransacaoBancaria pTransacaoBancaria)
        {
            throw new NotImplementedException();
        }*/

        public List<Object> EmitirExtrato(Int32 pQtdeDias)
        {
            throw new NotImplementedException();
        }
    }
}
