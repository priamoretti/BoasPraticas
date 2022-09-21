using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_2.aula3
{
    public class PagamentoDiretor : Pagamento
    {
        public float calcular(float salario)
        {
            return (salario * 0.07f) + salario;
        }
    }
}
