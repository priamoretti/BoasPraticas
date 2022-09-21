using System;
using System.Collections.Generic;
using System.Text;

namespace BoasPraticasProgramacao.Strategy.Exercicio
{
    public interface MeiosDePagamento
    {
        public double Pagar(double valor);
    }
}
