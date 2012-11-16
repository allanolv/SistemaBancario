﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoftSistBancario.Modelo
{
    public abstract class TransacaoBancaria
    {
        // Acrescentar uma propriedade da classe de conta corrente;
        public ContaCorrente.ContaCorrente ContaCorrente { get; set; }
        public DateTime DataEfetivacao { get; set; }
        public Decimal Valor { get; set; }
        public abstract Boolean Execute();
    }
}