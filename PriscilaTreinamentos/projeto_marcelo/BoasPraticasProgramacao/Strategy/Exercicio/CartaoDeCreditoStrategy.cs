using System;
using System.Collections.Generic;
using System.Text;

namespace BoasPraticasProgramacao.Strategy.Exercicio
{
    class CartaoDeCreditoStrategy : MeiosDePagamento
    {
        public double Pagar(double valor)
        {
            return valor + (valor * 0.35);
        }
    }
}
