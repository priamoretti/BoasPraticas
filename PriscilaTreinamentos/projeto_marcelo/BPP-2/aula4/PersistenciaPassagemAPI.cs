using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_2.aula4
{
    public class PersistenciaPassagemAPI : PersistenciaPassagem
    {
        public void persisitir(Passagem passagem)
        {
            Console.WriteLine("persistindo passagem na API Rodosoft");
        }
    }
}
