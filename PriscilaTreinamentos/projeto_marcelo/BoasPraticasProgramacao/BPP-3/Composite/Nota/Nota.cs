using System;
using System.Collections.Generic;
using System.Text;

namespace BoasPraticasProgramacao.BPP_3.Composite.Nota
{
    public interface Nota
    {
        List<string> linha();
        void InserirLinha(string linha);
    }
}
