using System;
using System.Collections.Generic;

namespace BoasPraticasProgramacao
{
    class Cadastrar
    {
        public void adiciona(Televisao t)
        {
            try
            {
                valida(t);
                list.Add(t);
            }
            catch (Exception)
            {

            }
        }

        public Televisao buscaTelevisao(String nome)
        {
            Televisao ret = null;
            foreach (Televisao t in list)
            {
                if (t.no.Equals(nome))
                {
                    ret = t;
                }
            }
            return ret;



        }

        List<Televisao> list = new List<Televisao>();
        private void valida(Televisao t)
        {
            if (t == null)
            {
                throw new Exception("Objecto Tv esta null");
            }
            if (t.no.Equals("") || (t.tamanho < 0 || t.tamanho > 100))
            {
                throw new Exception("dados da tv estao incorretos");
            }
        }

        // funcao nao usada
        //	public void adicionar(Televisao t) {
        //		
        //	}
    }
}
