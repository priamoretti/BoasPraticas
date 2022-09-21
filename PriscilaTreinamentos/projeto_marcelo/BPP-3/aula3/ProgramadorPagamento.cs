using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_3.aula3
{
    public class ProgramadorPagamento : Pagamento
    {
        public float calcular(float salario)
        {
            return (salario * 0.20f) + salario;
        }
    }
}
