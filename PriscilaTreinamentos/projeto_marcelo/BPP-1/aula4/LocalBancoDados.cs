using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_1.aula4
{
    public class LocalBancoDados : BancoDados
    {
        public void salvar(Passagem passagem)
        {
            Console.WriteLine("salvando pessoa localmente " + passagem.ToString());
        }
    }
}
