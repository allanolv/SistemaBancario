﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoftSistBancario.Modelo
{
    public class PessoaFisica : Cliente 
    {
        public Cliente cliente;
        public decimal Renda { get; set; }
        public string CPF { get; set; } 
    }
}
