using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoftSistBancario.Modelo
{
    public class Endereco
    {
        public TipoLogradouro TipoDeLogradouro { get; set; }
        public String Logradouro { get; set; }
        public String Numero { get; set; }
        public String Complemento { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        public String UF { get; set; }
        public String CEP { get; set; }

        public Endereco(TipoLogradouro pTipoLogradouro, String pLogradouro, String pNumero, String pComplemento, String pBairro, String pCidade, String pUF, String pCEP) {

            TipoDeLogradouro = pTipoLogradouro;
            Logradouro = pLogradouro;
            Numero = pNumero;
            Complemento = pComplemento;
            Bairro = pBairro;
            Cidade = pCidade;
            UF = pUF;
            CEP = pCEP;
        
        }
    }
}
