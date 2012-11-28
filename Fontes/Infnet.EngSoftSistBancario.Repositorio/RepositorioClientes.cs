using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infnet.EngSoftSistBancario.Modelo;
using Infnet.EngSoftSistBancario.Repositorio.Excecoes;


namespace Infnet.EngSoftSistBancario.Repositorio
{
    public class RepositorioClientes 
    {
        private static RepositorioClientes instanciaDoRepositorio = null;
        private RepositorioClientePessoaFisica rClientePessoaFisica;
        private RepositorioClientePessoaJuridica rClientePessoaJuridica;

        private RepositorioClientes()
        {
            rClientePessoaFisica = RepositorioClientePessoaFisica.Instancia();
            rClientePessoaJuridica = RepositorioClientePessoaJuridica.Instancia();
        }

        public static RepositorioClientes Instancia()
        {
            if (instanciaDoRepositorio == null)
                instanciaDoRepositorio = new RepositorioClientes();
            return instanciaDoRepositorio;
        }

        public List<Cliente> ListarClientesAtivos()
        {
            List<Cliente> vLstCliente = new List<Cliente>();
            vLstCliente.AddRange(rClientePessoaFisica.ListarClientesAtivos());
            vLstCliente.AddRange(rClientePessoaJuridica.ListarClientesAtivos());
            return vLstCliente;
        }

        public List<Cliente> ListarClientesPotencial() 
        {
            List<Cliente> vLstCliente = new List<Cliente>();
            vLstCliente.AddRange(rClientePessoaFisica.ListarClientesPotencial());
            vLstCliente.AddRange(rClientePessoaJuridica.ListarClientesPotencial());
            return vLstCliente;
        }
    }
}
