using System;
using System.Collections.Generic;
using System.Text;

namespace BoasPraticasProgramacao.Strategy
{
    public class IPIStrategy : Impostos
    {
        public double calcular(double valor)
        {
            return (valor * 0.5);
        }
    }
}
