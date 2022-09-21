using System;
using System.Collections.Generic;
using System.Text;

namespace BoasPraticasProgramacao.BPP_3.Builder
{
    public class NotaBuilder
    {
        private Nota nota;

        public NotaBuilder()
        {
            nota = new Nota();
        }
       

        public NotaBuilder notacomnumero()
        {
            nota.numeronota = true;
            return this;
        }

        public NotaBuilder notasemnumero()
        {
            nota.numeronota = false;
            return this;   
        }

        public NotaBuilder notacomitens()
        {
            nota.itens = true;
            return this;
        }

        public NotaBuilder notasemitens()
        {
            nota.itens = false;
            return this;
        }

        public NotaBuilder notacomdescricao()
        {
            nota.descricao = true;
            return this;
        }

        public NotaBuilder notasemdescricao()
        {
            nota.descricao = false;
            return this;
        }

        public NotaBuilder notacomvalor()
        {
            nota.valor = true;
            return this;
        }

        public NotaBuilder notacomobseracao()
        {
            nota.observacao = true;
            return this;
        }

        public Nota FazerNota()
        {
            return nota;
        }
    }
}
