using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_2.aula3
{
    public class CalculadoraPagamentoSalario
    {
        public float calcular(Pagamento pagamento,float salario)
        {
            return pagamento.calcular(salario);
        }
    }
}
