using ExercicioPagamento.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPagamento
{
    public class Servidor
    {
        public Models.Enums.Server servidor;
        public void EscolherServidor()
        {
            
            Console.WriteLine("Escolher servidor de pagamento!");
            Console.WriteLine("Servidores disponíveis:");

            foreach (var elemento in Enum.GetValues(typeof(Models.Enums.Server)))
            {
                Console.WriteLine(elemento.ToString());
            }
            servidor = (Models.Enums.Server)Convert.ToInt32(Console.ReadLine());
            try
            {
                Uteis.ValidarOpcaoEnum(servidor);
            }
            catch
            {
                EscolherServidor();
            }
            
        }
    }
}
