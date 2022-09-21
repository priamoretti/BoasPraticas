using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_3.aula4
{
    public class LocalArmazenamentoImpl : Armazenamento
    {
        public void persistir(Passagem passagem)
        {
            Console.WriteLine("salvando passagem no disco rigido");
        }
    }
}
