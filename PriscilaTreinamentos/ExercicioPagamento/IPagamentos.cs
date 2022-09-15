using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPagamento
{
    public interface IPagamentos
    {
        public T ColetarDados<T>();
        public T Validar<T>(string dado);
    }
}
