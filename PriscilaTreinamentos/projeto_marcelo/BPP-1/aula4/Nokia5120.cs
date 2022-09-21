using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_1.aula4
{
    public class Nokia5120 : Telefone
    {
        public void enviarMensagem()
        {
            Console.WriteLine("nokia5120 enviando mensagem");
        }

        public void ligar()
        {
            Console.WriteLine("nokia5120 ligando");
        }

        public void receberMensagem()
        {
            Console.WriteLine("nokia5120 recebendo menagem");
        }
    }
}
