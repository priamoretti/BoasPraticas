using System;
using System.Collections.Generic;
using System.Text;

namespace BoasPraticasProgramacao.BPP_3.Composite
{
    public class Composite
    {
        List<PontosDeVenda> listPontoVenda = new List<PontosDeVenda>();

        public void adicionarPontoDeVenda(PontosDeVenda pontosdevenda)
        {
            this.listPontoVenda.Add(pontosdevenda);
        }
            
        public int retornaTotalComprasDoDia()
        {
            int totalComprasDia = 0;
            foreach (PontosDeVenda pontovenda in listPontoVenda)
            {
                totalComprasDia = totalComprasDia + pontovenda.totalCompras();
            }

            return totalComprasDia;
        }
    }
}
