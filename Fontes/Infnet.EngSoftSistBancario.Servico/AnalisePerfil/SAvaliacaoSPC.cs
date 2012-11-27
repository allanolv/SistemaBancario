using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infnet.EngSoftSistBancario.Modelo;

namespace Infnet.EngSoftSistBancario.Servico
{
    public class SAvaliacaoSPC : IServicoAvaliacaoPerfilPadrao
    {
        Random random;
        Double number = 0;

        public SAvaliacaoSPC()
        {
            random = new Random();
        }

        public Double Avaliar(Cliente pCliente)
        {
            number = random.NextDouble();
            return System.Math.Round(number, 1);
        }
    }
}
