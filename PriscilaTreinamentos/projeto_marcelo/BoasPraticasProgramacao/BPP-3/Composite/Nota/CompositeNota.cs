using System;
using System.Collections.Generic;
using System.Text;

namespace BoasPraticasProgramacao.BPP_3.Composite.Nota
{
    public class CompositeNota
    {

        List<Nota> notasfiscais = new List<Nota>();

        public void adicionarNotaFiscal(Nota linhanota)
        {
            this.notasfiscais.Add(linhanota);
        }

        public void retornaNFPronta()
        {
            foreach (Nota nf in notasfiscais)
            {
                foreach(string lista in nf.linha())
                {
                    Console.WriteLine(lista + "\n");
                }
            }
        }
    }
}
