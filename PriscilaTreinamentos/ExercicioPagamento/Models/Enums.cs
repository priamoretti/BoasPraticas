using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPagamento.Models
{
    public class Enums
    {
        public enum Server
        {
            OuroePrata1 = 1,
            Frederes2= 2
        }

        public enum Pagamento
        {
            Dinheiro1 = 1,
            Pix2 = 2,
            CartãoCredito3 = 3,
            CartãoDebito4 = 4
        }
       
    }
}
