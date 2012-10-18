using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoftSistBancario.Repositorio
{
  public  class RepositorioDeClientes
    {
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
  
      public Boolean CadastrarCPF(PessoaFisica pFisica)
      {
          throw new NotImplementedException();
      }

      public Boolean CadastrarCNPJ(PessoaJuridica pJuridica)
      {
          throw new NotImplementedException();
      }

      public Boolean CadastrarEndereco (Endereco pEndereco)
      {
          throw new NotImplementedException();
      }
      public Boolean EnviarSolicitacao(Cliente pCliente)
      {
          throw new NotImplementedException();
      }

   

    }
}
