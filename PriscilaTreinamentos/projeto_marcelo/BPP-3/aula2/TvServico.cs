using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis;

namespace BoasPraticasProgramacao
{
    public  class TvServico
    {
        List<Televisao> list = new List<Televisao>();

        public void adicionar(Televisao televisao)
        {
            try
            {
                validar(televisao);
                list.Add(televisao);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                // tela grafica e.message
            }
        }

        public Optional<Televisao> buscarTelevisao(String nome)
        {
            foreach (var tv in list)
            {
                if (tv.nome.Equals(nome))
                {
                    return new Optional<Televisao>(tv);
                }
            }
            return new Optional<Televisao>();            
        }
        
        private void validar(Televisao televisao)
        {
            if (eTelevisaoNula(televisao))
            {
                throw new Exception("Objecto Tv esta null");
            }
            if (eNomeTvEmBranco(televisao) || eTamanhoTvInvalido(televisao))
            {
                throw new Exception("dados da tv estao incorretos");
            }
        }

        private static bool eTamanhoTvInvalido(Televisao televisao)
        {
            return (televisao.tamanho < 0 || televisao.tamanho > 100);
        }

        private static bool eNomeTvEmBranco(Televisao televisao)
        {
            return televisao.nome.Equals("");
        }

        private static bool eTelevisaoNula(Televisao televisao)
        {
            return televisao == null;
        }
    }
}
