using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoftSistBancario.Modelo
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string Nome { get; set; }
        public List<Endereco> Enderecos { get; set; }
        public List<Telefone> Telefones { get; set; }
        public Boolean Ativo { get; set; }

        public Cliente()
        {
            
        }

    }
}
