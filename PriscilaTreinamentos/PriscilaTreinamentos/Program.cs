using PriscilaTreinamentos.Telefone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriscilaTreinamentos
{
    class Program
    {
        static void Main(string[] args)
        {

            IPlanoCelularInternet celular = new IPlanoCelularInternet();
            celular.EntrarInternet();
            celular.EnviarMensagem();

            //Console.WriteLine("teste");
        }
        
    }
}
