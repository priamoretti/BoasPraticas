using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_2.aula3
{
    public class PagamentoProgramador : Pagamento
    {
        public float calcular(float salario)
        {
            return (salario * 0.20f) + salario;
        }
    }
}
