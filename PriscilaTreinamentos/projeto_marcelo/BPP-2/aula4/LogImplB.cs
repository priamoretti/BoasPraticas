using System;
using System.Collections.Generic;
using System.Text;
using BoasPraticasProgramacao;

namespace BPP_2.aula4
{
    public class LogImplB : Log
    {
        public void log(string texto)
        {
            Console.WriteLine("LOG-IMPL-B: " + texto);
        }
    }
}
