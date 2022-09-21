using System;
using System.Collections.Generic;
using System.Text;
using BoasPraticasProgramacao;

namespace BPP_2.aula4
{
    public class LogImplA : Log
    {
        public void log(string texto)
        {
            Console.WriteLine("LOG_IMPL_A: " + texto);
        }
    }
}
