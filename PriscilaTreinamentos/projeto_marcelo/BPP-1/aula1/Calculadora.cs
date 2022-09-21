using System;

namespace aula1
{
    public class Calculadora
    {
        public int somar(int valorA, int valorB)
        {
            var resultado = valorA + valorB;
            return resultado;
        }

        public int somarComVirgula()
        {
            return -1;
        }
        public int somarSemVirgula()
        {
            return -1;
        }

        public int buscarChave(int id)
        {
            if (eIdInvalido(id))
            {
                throw new Exception("Id invalido");
            }

            return 1; // processaAlgo
        }

        bool eIdInvalido(int id)
        {
            return id == null || id.Equals("");
        }
    }
}
