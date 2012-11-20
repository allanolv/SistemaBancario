using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoftSistBancario.Modelo
{
    public class Telefone
    {
        public TipoTelefone Tipo { get; set; }
        public String DDD { get; set; }
        public String Numero { get; set; }

        public Telefone(TipoTelefone pTipo, String pDDD, String pNumero)
        {
            Tipo = pTipo;
            DDD = pDDD;
            Numero = pNumero;
        }
    }
}
