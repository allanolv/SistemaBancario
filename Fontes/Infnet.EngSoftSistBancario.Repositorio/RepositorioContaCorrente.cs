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

        private String GerarNumeroCC()
        {
            // Perguntar ao professor e depois fatorar
            Random random = new Random();
            Double vNumber = 0;
            Double vDigito = 0;
            vNumber = random.NextDouble() * 100000;
            vDigito = vNumber / 9;
            vDigito = Math.Truncate(vDigito);
            return System.Math.Round(vNumber).ToString() + "-" + vDigito.ToString().Substring(1, 1);
        }

        public ContaCorrente CriarContaCorrente(Cliente pTitular, String pAgencia, Decimal pTarifaMensal)
        {
            String vNumero = GerarNumeroCC();
            ContaCorrente vContaCorrente = new ContaCorrente(pTitular, pAgencia, vNumero, pTarifaMensal);
            return vContaCorrente;
        }

        public ContaCorrenteEspecial CriarContaCorrente(Cliente pTitular, String pAgencia, Decimal pTarifaMensal, Decimal pLimite)
        {
            String vNumero = GerarNumeroCC();
            ContaCorrenteEspecial vContaCorrenteEspecial = new ContaCorrenteEspecial(pTitular, pAgencia, vNumero, pTarifaMensal, pLimite);
            Inserir<ContaCorrenteEspecial>(vContaCorrenteEspecial);
            return vContaCorrenteEspecial;
        }


        public void Inserir<CC>(CC pContaCorrente)  where CC : ContaCorrente
        {
            try
            {
                if (ObterContaCorrente<CC>(pContaCorrente.Agencia, pContaCorrente.Numero) != null)
                    throw new ExContaCorrenteExistente("Conta corrente existente");
                _lstContaCorrente.Add(pContaCorrente);
            }
            catch (Exception e)
            {
                throw new Exception("Não é possível incluir a conta corrente. "+Environment.NewLine+e.Message);
            }
        }

        public void Alterar<CC>(CC pContaCorrente) where CC : ContaCorrente
        {
            try
            {
                Int32 vIndex = _lstContaCorrente.IndexOf(pContaCorrente);
                if (vIndex >= 0)
                    _lstContaCorrente[vIndex] = pContaCorrente;
                else
                    throw new ExContaCorrenteNaoEncontrada("Conta corrente não encontrada");
            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível alterar a conta corrente. " + Environment.NewLine + e.Message);
            }
        }

        public CC ObterContaCorrente<CC>(String pAgencia, String pNumeroContaCorrente) where CC : ContaCorrente
        {
            return _lstContaCorrente.Where(cc => cc.Agencia==pAgencia && cc.Numero == pNumeroContaCorrente).Cast<CC>().FirstOrDefault();
        }

        public ContaCorrente ListarContaCorrentePorCliente(Cliente pCliente)
        {
            return _lstContaCorrente.Where(cc => cc.Titular.Documento == pCliente.Documento).ToList().FirstOrDefault();
        }

    }
}

