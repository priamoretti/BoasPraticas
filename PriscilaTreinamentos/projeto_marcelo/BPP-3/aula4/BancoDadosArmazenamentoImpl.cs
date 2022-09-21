using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_3.aula4
{
    public class BancoDadosArmazenamentoImpl : Armazenamento
    {
        public void persistir(Passagem passagem)
        {
            Console.WriteLine("persistindo passagem pelo banco de dados");
        }
    }
}
