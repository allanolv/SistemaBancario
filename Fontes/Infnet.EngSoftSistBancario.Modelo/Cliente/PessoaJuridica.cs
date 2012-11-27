using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoftSistBancario.Modelo
{
    public class PessoaJuridica : Cliente
    {
        private String _cnpj = String.Empty;
        // Atributos
        public String CNPJ
        {
            get { return _cnpj; }
            set { _cnpj = value; AlterarNumeroDocumento(); }
        }
        public Decimal Receita { get; set; }
        // Métodos
        protected override void AlterarNumeroDocumento()
        {
            Documento = CNPJ;
        }
    }
}
