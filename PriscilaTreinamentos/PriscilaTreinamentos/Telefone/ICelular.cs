using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriscilaTreinamentos
{
    public interface ICelular
    {
        void Ligar();
        void EnviarMensagem();
        void ReceberMensagem();       
    }
}
