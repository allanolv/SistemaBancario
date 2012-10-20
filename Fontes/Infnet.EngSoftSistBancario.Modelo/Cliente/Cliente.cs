using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoftSistBancario.Modelo
{
    public abstract class Cliente
    {
        public string Nome { get; set; }
        public List<Endereco> Enderecos { get; set; }
        public List<Telefone> Telefones { get; set; }
        public Boolean Ativo { get; set; }
    }
}
