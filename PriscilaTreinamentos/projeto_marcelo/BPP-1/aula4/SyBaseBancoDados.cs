using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_1.aula4
{
    public class SyBaseBancoDados : BancoDados
    {
        public void salvar(Passagem passagem)
        {
            Console.WriteLine("salvando pelo banco de dados sybase");
        }
    }
}
