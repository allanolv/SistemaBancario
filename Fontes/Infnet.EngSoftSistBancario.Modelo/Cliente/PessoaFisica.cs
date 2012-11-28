using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoftSistBancario.Modelo
{
    public class PessoaFisica : Cliente 
    {
        private String _cpf = String.Empty;
        // Atributos
        public String CPF
        {
            get { return _cpf; }
            set { _cpf = value; AlterarNumeroDocumento(); }
        }
        public decimal Renda { get; set; }
        // Métodos 
        protected override void AlterarNumeroDocumento()
        {
            Documento = _cpf;
        }
    }
}
