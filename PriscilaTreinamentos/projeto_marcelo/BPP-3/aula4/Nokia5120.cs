using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_3.aula4
{
    public class Nokia5120 : Celular
    {
        public void enviarMensagem()
        {
            Console.WriteLine("nokika 5120 envinado mensagem");
        }

        public void ligar()
        {
            Console.WriteLine("nokika 5120 ligando");
        }

        public void receberMensagem()
        {
            Console.WriteLine("nokika 5120 recebendo mensagem");
        }
    }
}
