using System;
using System.Collections.Generic;
using System.Text;

namespace BoasPraticasProgramacao.BPP_3.Composite.Nota
{
    public class NotaDeItens : Nota
    {
        List<string> linhasdanota = new List<string>();
        public void InserirLinha(string linha)
        {

            linhasdanota.Add(linha); 
        }

        public List<string> linha()
        {
            return linhasdanota;
        }
    }
}
