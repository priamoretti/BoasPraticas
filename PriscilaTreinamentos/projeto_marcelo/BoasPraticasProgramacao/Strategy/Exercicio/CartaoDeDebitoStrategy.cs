using System;
using System.Collections.Generic;
using System.Text;

namespace BoasPraticasProgramacao.Strategy.Exercicio
{
    class CartaoDeDebitoStrategy : MeiosDePagamento
    {
        public double Pagar(double valor)
        {
            return valor;

        }
    }
}
