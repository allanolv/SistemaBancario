using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoftSistBancario.Modelo
{
    public class Telefone
    {
        public String DDD { get; set; }
        public String Numero { get; set; }
        public TipoTelefone Tipo { get; set; }

        public Telefone(String pDDD, String pNumero, TipoTelefone pTipo)
        {
            DDD = pDDD;
            Numero = pNumero;
            Tipo = pTipo;
        }

    }
}
