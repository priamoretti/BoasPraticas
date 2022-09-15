using System;
using System.Collections.Generic;
using System.Text;


namespace ExercicioPagamento
{
    public class Pix : IPagamentos
    {
      
        public Dinheiro ColetarDados<Dinheiro>()
        {
            throw new NotImplementedException();
        }


        public Dinheiro Validar<Dinheiro>(string dado)
        {
            throw new NotImplementedException();
        }
    }
}
