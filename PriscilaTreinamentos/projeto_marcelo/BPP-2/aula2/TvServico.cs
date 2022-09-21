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
                valida(televisao);
                listaTv.Add(televisao);
            }
            catch (Exception e)
            {
                // mostrar ui e.Message();
                Console.WriteLine(e.StackTrace);
            }
        }

        public Televisao buscarTelevisao(string nome)
        {
            Televisao retorno = null;
            foreach (var tv in listaTv)
            {
                if (tv.nome.Equals(nome))
                {
                    retorno = tv;
                }
            }
            return retorno;
        }


        private void valida(Televisao televisao)
        {
            var isNull = televisao == null;
            if (isNull)
            {
                throw new Exception("Objecto Tv esta null");
            }
            var eVAzioNomeTv = televisao.nome.Equals("");
            if (eVAzioNomeTv)
            {
                throw new Exception("nome tv incorretos");
            }
            var isTamanhoInvalidoTv = (televisao.tamanho < 0 || televisao.tamanho > 100);
            if (isTamanhoInvalidoTv)
            {
                throw new Exception("tamanho tv esta incorretos");
            }
        }

        public Optional<Televisao> buscar(int id)
        {
            Televisao tv = null; // faz a busca da tv
            return new Optional<Televisao>(tv);
        }
    }
}
