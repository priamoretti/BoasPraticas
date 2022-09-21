using System;

namespace BoasPraticasProgramacao
{
    class Baleia : Bixo
    {
        public void caminha()
        {
            throw new NotImplementedException("baleia não caminha :(");
        }

        public void nada()
        {
            Console.WriteLine("Baleia nadando");
        }
    }
}

