using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_1.aula4
{
    public class Log4J : Log
    {
        public void log(string texto)
        {
            Console.WriteLine("INFOR:..... " + texto);
        }
    }
}
