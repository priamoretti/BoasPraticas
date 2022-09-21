using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_3.aula4
{
    public class Cachorro : BichosAquaticos, BichosTerrestres
    {
        public void caminhar()
        {
            Console.WriteLine("cachorro caminhando");
        }

        public void nadar()
        {
            Console.WriteLine("cachorro nadando");
        }

        public void respirar()
        {
            Console.WriteLine("cachorro respirando");
        }
    }
}
