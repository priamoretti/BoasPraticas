using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_1.aula4
{
    public class Sistema
    {
        public BancoDados bancoDados { get; set; }

        public Sistema(BancoDados bancoDados)
        {
            this.bancoDados = bancoDados;
        }

        public void salvar(Passagem passagem)
        {
            bancoDados.salvar(passagem);
        }
    }
}
