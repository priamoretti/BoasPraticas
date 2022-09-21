using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_3.aula4
{
    public class ProcessaArmazenamento
    {
        Armazenamento armazenamento;

        public ProcessaArmazenamento(Armazenamento armazenamento)
        {
            this.armazenamento = armazenamento;
        }

        public void executarPersitencia(Passagem passagem)
        {
            armazenamento.persistir(passagem);
        }

    }
}
