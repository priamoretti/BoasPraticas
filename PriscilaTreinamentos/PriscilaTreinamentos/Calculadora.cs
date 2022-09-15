using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriscilaTreinamentos
{

    class Calculadora
    {
        int somar(int valora, int valorb)
        {
            return valora + valorb;
        }
    }


    class Chave
    {
        public int buscarChavePorId(string Id)
        {
            bool EhIdInvalido = (Id.Equals("null") || Id.Equals(""));
            if (EhIdInvalido)
            {
                throw new Exception("Id Inválido");
            }

            return 0;
        }
    }
    
}
