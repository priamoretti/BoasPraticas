using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_3.aula3
{
    public class CalculadoraPagamento
    {
        public float calcular(Pagamento pagamento, float salario) 
        {
            return pagamento.calcular(salario);
        }
    }
}
