using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPagamento
{
    public class Uteis
    {
        public static void ValidarOpcaoEnum(Enum enumaservalidado)
        {

            if (!Enum.IsDefined(typeof(Models.Enums.Server), enumaservalidado))
            { 
                Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida!");
            }
        }
    }
}
