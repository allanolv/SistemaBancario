using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infnet.EngSoftSistBancario.Modelo;
using Infnet.EngSoftSistBancario.Modelo.ContaCorrente;

namespace Infnet.EngSoftSistBancario.Repositorio
{
    public class RepositorioContaCorrente
    {
        private static RepositorioContaCorrente instanciaDoRepositorio = null;

        private RepositorioContaCorrente()
        {

        }

        public static RepositorioContaCorrente Instancia()
        {
            if (instanciaDoRepositorio == null)
                instanciaDoRepositorio = new RepositorioContaCorrente();
            return instanciaDoRepositorio;
        }

        public Boolean Inserir(ContaCorrente pContaCorrente)
        {
            return true;
        }

        public Boolean Alterar(ContaCorrente pContaCorrente)
        {
            return true;
        }

    }
}
