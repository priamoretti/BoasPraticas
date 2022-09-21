using System;
using System.Collections.Generic;
using System.Text;

namespace BoasPraticasProgramacao.Strategy.Exercicio
{
    class DinheiroStrategy : MeiosDePagamento
    {
        public double Pagar(double valor)
        {

            return valor - (valor * 0.5);
        }
    }
}
