using System;
using System.Collections.Generic;
using System.Text;

namespace BoasPraticasProgramacao.Strategy.Exercicio
{
    class PixStrategy : MeiosDePagamento
    {
        public double Pagar(double valor)
        {
            return valor;
        }
    }
}
