using System;

namespace BoasPraticasProgramacao
{
    public class CalculadoraImposto
    {
        double ACRESCIMENTO_ICMS = 0.10f;
        double ACRESCIMENTO_IPI = 0.20f;
        double ACRESCIMENTO_NOVO_IMPOSTO = 0.50f;

        public double calcular(string imposto, double valor)
        {
            if (imposto.Equals("ICMS"))
            {
                return valor * ACRESCIMENTO_ICMS;
            }
            else if (imposto.Equals("IPI"))
            {
                return valor * ACRESCIMENTO_ICMS;
            }
            else if (imposto.Equals("NOVO_IMPOSTO"))
            {
                return valor * ACRESCIMENTO_ICMS;
            }
            else
            {
                throw new Exception("Error ao calcular");
            }
        }
    }

}
