using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriscilaTreinamentos.Telefone
{
    public class IPlanoCelularInternet : ICelularInternet
    {
        public void EntrarInternet()
        {
            Console.WriteLine("Navegando...");
        }

        public void EnviarMensagem()
        {
            Console.WriteLine("Enviando....");
        }

        public void Ligar()
        {
            Console.WriteLine("Enviando....");
        }

        public void ReceberMensagem()
        {
            Console.WriteLine("Enviando....");
        }
    }
}
