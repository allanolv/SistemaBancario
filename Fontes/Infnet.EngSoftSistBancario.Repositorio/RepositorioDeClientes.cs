using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infnet.EngSoftSistBancario.Modelo;

namespace Infnet.EngSoftSistBancario.Repositorio
{
    public class RepositorioDeClientes
    {
        private static RepositorioDeClientes instanciaDoRepositorio = null;

        private RepositorioDeClientes()
        {

        }

        public static RepositorioDeClientes Instancia()
        {
            if (instanciaDoRepositorio == null)
                instanciaDoRepositorio = new RepositorioDeClientes();
            return instanciaDoRepositorio;
        }


        public Boolean Inserir(Cliente pCliente)
        {
            return true;
        }

        public Boolean Alterar(Cliente pCliente)
        {
            return true;
        }

    }
}
