using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inf.EngSoftSistBancario.Modelo.Clientes
{
    public class Telefone
    {
        public int DDD { get; set; }
        public int Numero { get; set; }
        public string Tipo { get; set; }

        public Cliente Cliente
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
