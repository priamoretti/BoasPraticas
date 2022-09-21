using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_1.aula4
{
    public class Cachorro : BixoCaminha, BixoNada
    {
        public void caminhar()
        {
            Console.WriteLine("cachorro caminhando");
        }

        public void nadar()
        {
            Console.WriteLine("cachorro nadando");
        }
    }
}
