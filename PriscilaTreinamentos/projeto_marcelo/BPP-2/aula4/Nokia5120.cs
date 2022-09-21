using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_2.aula4
{
    public class Nokia5120 : Telefone
    {
        public void enviarMensagem()
        {
            Console.WriteLine("envinado mensangem nokia");
        }

        public void ligar()
        {
            Console.WriteLine("ligando nokia.....");
        }

        public void receberMensagem()
        {
            Console.WriteLine("recebendo mensagem nokia.");
        }
    }
}
