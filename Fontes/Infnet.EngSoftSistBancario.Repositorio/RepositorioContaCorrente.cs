using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infnet.EngSoftSistBancario.Modelo;
using Infnet.EngSoftSistBancario.Repositorio.Excecoes;

namespace Infnet.EngSoftSistBancario.Repositorio
{
    public class RepositorioContaCorrente
    {
        private List<ContaCorrente> _lstContaCorrente;
        private static RepositorioContaCorrente instanciaDoRepositorio = null;

        private RepositorioContaCorrente()
        {
            _lstContaCorrente = new List<ContaCorrente>();
        }

        public static RepositorioContaCorrente Instancia()
        {
            if (instanciaDoRepositorio == null)
                instanciaDoRepositorio = new RepositorioContaCorrente();
            return instanciaDoRepositorio;
        }

        public void Inserir<CC>(CC pContaCorrente)  where CC : ContaCorrente
        {
            try
            {
                _lstContaCorrente.Add(pContaCorrente);
            }
            catch (Exception e)
            {
                throw new Exception("Não é possível incluir a conta corrente"+Environment.NewLine+e.Message);
            }
        }

        public void Alterar<CC>(CC pContaCorrente) where CC : ContaCorrente
        {
            Int32 vIndex = _lstContaCorrente.IndexOf(pContaCorrente);
            if (vIndex >= 0)
            {
                try
                {
                    _lstContaCorrente[vIndex] = pContaCorrente;
                }
                catch (Exception e)
                {
                    throw new Exception("Não foi possível alterar a conta corrente. " + Environment.NewLine + e.Message);
                }
            }
            else
                throw new ExContaCorrenteNaoEncontrada("Conta corrente não encontrada");
        }

        public CC ObterContaCorrente<CC>(String pNumeroContaCorrente) where CC : ContaCorrente
        {
            throw new NotImplementedException();
            /*ContaCorrenteEspecial cce = (_lstContaCorrente[0]);

            return _lstContaCorrente.Where(cc => cc.Numero == pNumeroContaCorrente).Cast<CC>().FirstOrDefault();
             */
        }

    }
}

