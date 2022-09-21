using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_1.aula3
{
    public class ProcessaPagamento
    {
        public float processarCalculo(Pagamento pagamento,float salario)
        {
            return pagamento.calcular(salario);
        }
    }
}
