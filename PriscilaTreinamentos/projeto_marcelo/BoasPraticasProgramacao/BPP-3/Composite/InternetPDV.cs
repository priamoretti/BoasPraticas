using System;
using System.Collections.Generic;
using System.Text;

namespace BoasPraticasProgramacao.BPP_3.Composite
{
    public class InternetPDV : PontosDeVenda
    {

        int total = 0;
        public void realizarCompras(int totalCompra)
        {
            total = total + totalCompra;
        }

        public int totalCompras()
        {
            return total;
        }
    }
}
