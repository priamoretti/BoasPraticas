using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_3.aula4
{
    public interface Armazenamento
    {
        public void persistir(Passagem passagem);
    }
}
