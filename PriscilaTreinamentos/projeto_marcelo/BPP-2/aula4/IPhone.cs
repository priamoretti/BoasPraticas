using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_2.aula4
{
    public class IPhone : SmartPhone
    {
        public void conectarInternet()
        {
            Console.WriteLine("conectando internet");
        }

        public void enviarMensagem()
        {
            Console.WriteLine("enviando mensagem");
        }

        public void ligar()
        {
            Console.WriteLine("ligando ");
        }

        public void receberMensagem()
        {
            Console.WriteLine("recebendo");
        }
    }
}
