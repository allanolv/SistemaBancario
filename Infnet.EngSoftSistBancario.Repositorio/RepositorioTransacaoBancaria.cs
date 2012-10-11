using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infnet.EngSoftSistBancario.Modelo;

namespace Infnet.EngSoftSistBancario.Repositorio
{
    public class RepositorioTransacaoBancaria
    {
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

        public Comprovante EmitirComprovante(TransacaoBancaria pTransacaoBancaria)
        {
            throw new NotImplementedException();
        }

        public List<Object> EmitirExtrato(Int32 pQtdeDias)
        {
            throw new NotImplementedException();
        }

    }
}
