using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_3.aula4
{
    public class ApiArmazenamentoImpl : Armazenamento
    {
        public void persistir(Passagem passagem)
        {
            Console.WriteLine("salvando via API");
        }
    }
}
