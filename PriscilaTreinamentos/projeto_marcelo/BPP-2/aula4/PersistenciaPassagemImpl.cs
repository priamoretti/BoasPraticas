using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_2.aula4
{
    public class PersistenciaPassagemImpl
    {
        public PersistenciaPassagem persistenciaPassagem { get; set; }

        public PersistenciaPassagemImpl(PersistenciaPassagem persistencia)
        {
            this.persistenciaPassagem = persistencia;
        }

        public void persistir(Passagem passagem)
        {
            persistenciaPassagem.persisitir(passagem);
        }
    }
}
