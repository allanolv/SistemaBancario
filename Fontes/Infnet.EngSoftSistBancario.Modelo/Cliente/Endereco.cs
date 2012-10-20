using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoftSistBancario.Modelo
{
    public class Endereco
    {
        public string  TipoDeLogradouro { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string  Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public int CEP { get; set; }
    }
}
