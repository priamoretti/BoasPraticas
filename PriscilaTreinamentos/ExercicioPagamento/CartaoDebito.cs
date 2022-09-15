using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPagamento
{
    public class CartaoDebito : IPagamentos
    {
       

        public T ColetarDados<T>()
        {
            throw new NotImplementedException();
        }

     

        public T Validar<T>(string dado)
        {
            throw new NotImplementedException();
        }
    }
}
