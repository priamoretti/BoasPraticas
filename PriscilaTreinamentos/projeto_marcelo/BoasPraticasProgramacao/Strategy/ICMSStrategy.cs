using System;
using System.Collections.Generic;
using System.Text;

namespace BoasPraticasProgramacao.Strategy
{
    public class ICMSStrategy : Impostos
    {
        public double calcular(double valor)
        {
            return (valor * 10) - 2;
        }
    }
}
