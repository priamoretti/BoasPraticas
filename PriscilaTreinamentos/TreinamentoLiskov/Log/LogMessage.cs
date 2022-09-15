using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoLiskov.Log
{
    public class LogMessage : Log
    {
        public void log(string texto)
        {

            Console.WriteLine(texto + "   console");
            // MessageBox.Show(texto);
        }
    }
}
