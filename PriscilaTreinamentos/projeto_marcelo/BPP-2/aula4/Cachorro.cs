using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_2.aula4
{
    public class Cachorro : BixoAquatico, BixoTerrestre
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
