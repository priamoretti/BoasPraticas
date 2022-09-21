using System.Collections.Generic;

namespace BoasPraticasProgramacao
{
    public class TotalComprasComposite
    {
        List<TotalCompras> listaTotalCompras = new List<TotalCompras>();

        public void adicionaTotalCompras(TotalCompras totalCompras)
        {
            this.listaTotalCompras.Add(totalCompras);
        }

        public int retornaTotalComprasDoDia()
        {
            int totalComprasDia = 0;
            foreach (TotalCompras totalCompras in listaTotalCompras)
            {
                totalComprasDia += totalCompras.totalCompras();
            }
            return totalComprasDia;
        }
    }


}
