using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_1.aula4
{
    public class MylsqlBancoDAdos : BancoDados
    {
        public void salvar(Passagem passagem)
        {
            Console.WriteLine("Salvando passagem no mysql");
        }
    }
}
