using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_2.aula4
{
    public class BancoDadosMysql : BancoDados
    {
        public void conectar()
        {
            Console.WriteLine("conectando banco de dados mysql");
        }

        public void monitorar()
        {
            Console.WriteLine("monitorando banco de dados mysql"); ;
        }
    }
}
