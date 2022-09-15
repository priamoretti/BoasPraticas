using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriscilaTreinamentos
{
    public interface ICelular
    {
        public void Ligar();
        public void EnviarMensagem();
        public void ReceberMensagem();       
    }
}
