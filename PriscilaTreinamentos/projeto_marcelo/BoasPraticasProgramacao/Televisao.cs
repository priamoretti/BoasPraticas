using System;

namespace BoasPraticasProgramacao
{
    class Televisao
    {
        public Televisao(String n, int t)
        {
            if (valida(n, t) < 0)
            {
                throw new Exception("error");
            }
            no = n;
            tamanho = t;
        }






        // valida os dados da televisao
        private int valida(String n, int t)
        {
            if (n.Equals("") || (t < 0 || t > 100))
            {
                return -1; // error
            }
            else
            {
                return 1; // ok
            }
        }


        public String no { get; set; } // nome da tv
        public int tamanho { get; set; } // tamanho
    }
}
