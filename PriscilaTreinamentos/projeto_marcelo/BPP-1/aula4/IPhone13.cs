using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_1.aula4
{
    public class IPhone13 : SmartPhone
    {
        public void conectarInternet()
        {
            Console.WriteLine("iphone conectando na internet");
        }

        public void enviarMensagem()
        {
            Console.WriteLine("iphone enviando mensagem");
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
