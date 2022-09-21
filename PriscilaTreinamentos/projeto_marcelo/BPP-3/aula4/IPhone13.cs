using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_3.aula4
{
    public class IPhone13 : CelularInternet
    {
        public void conectarInternet()
        {
            Console.WriteLine("iphone conectando a internet");
        }

        public void enviarMensagem()
        {
            Console.WriteLine("iphone envinado mesagem");
        }

        public void ligar()
        {
            Console.WriteLine("iphone ligando");
        }

        public void receberMensagem()
        {
            Console.WriteLine("iphone recebendo mensagem");
        }
    }
}
