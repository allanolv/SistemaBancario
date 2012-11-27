using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infnet.EngSoftSistBancario.Modelo;

namespace Infnet.EngSoftSistBancario.Servico
{
    interface IServicoAvaliacaoPerfilPadrao
    {
        Double Avaliar(Cliente pCliente);
    }
}
