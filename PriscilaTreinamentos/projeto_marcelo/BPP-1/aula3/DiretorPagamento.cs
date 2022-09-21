using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_1.aula3
{
    public class DiretorPagamento : Pagamento
    {
        public float calcular(float salario)
        {
            return (salario * 7) + salario;
        }
    }
}
