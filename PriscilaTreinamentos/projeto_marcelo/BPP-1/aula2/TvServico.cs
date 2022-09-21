using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis;

namespace BoasPraticasProgramacao
{
    public class TvServico
    {
        List<Televisao> listaTv = new List<Televisao>();

        public void adicionar(Televisao televisao)
        {
            try
            {
                validar(televisao);
                listaTv.Add(televisao);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error", e.StackTrace);
                throw e;
            }
        }

        public Optional<Televisao> buscarTelevisao(String nome)
        {
            Televisao retorno = null;
            foreach (var tv in listaTv)
            {
                if (tv.nome.Equals(nome))
                {
                    retorno = tv;
                }
            }
            return new Optional<Televisao>(retorno);

        }
        
        private void validar(Televisao televisao)
        {
            
            if (string.IsNullOrEmpty(televisao.ToString()))
            {
                throw new Exception("Objecto Tv esta null");
            }
            if (string.IsNullOrEmpty(televisao.nome))
            {
                throw new Exception("Nome da tv esta eerrado");
            }
            bool eTamanhoInvalido = televisao.tamanho < 0 || televisao.tamanho > 100;
            if (eTamanhoInvalido)
            {
                throw new Exception("tamanho da tv esta errado");
            }
        }
    }
}
