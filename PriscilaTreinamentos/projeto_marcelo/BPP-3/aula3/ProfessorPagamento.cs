using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_3.aula3
{
    public class ProfessorPagamento : Pagamento
    {
        public float calcular(float salario)
        {
            return salario + (salario * 0.5f);
        }
    }
}
