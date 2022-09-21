using System;
using System.Collections.Generic;
using System.Text;

namespace BoasPraticasProgramacao.Strategy
{
    public class ImpostoContexto
    {
        public Impostos getStrategy(string tipoImposto)
        {
            if (tipoImposto.Equals("ICMS"))
            {
                return new ICMSStrategy();
            }

            if (tipoImposto.Equals("IPI"))
            {
                return new IPIStrategy();
            }


            throw new Exception("Tipo imposto inválido");
        }

        public double calcular(string tipoImposto, double valor)
        {
            if (tipoImposto.Equals("ICMS"))
            {
                return new ICMSStrategy().calcular(valor);

            }

            if (tipoImposto.Equals("IPI"))
            {
                return new IPIStrategy().calcular(valor);
            }

            throw new Exception("Tipo imposto inválido");
        }

    }
}
