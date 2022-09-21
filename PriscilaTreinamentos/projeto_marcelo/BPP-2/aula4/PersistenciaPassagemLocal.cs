using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_2.aula4
{
    public class PersistenciaPassagemLocal : PersistenciaPassagem
    {
        public void persisitir(Passagem passagem)
        {
            Console.WriteLine("persistendo passagem de forma local");
        }
    }
}
