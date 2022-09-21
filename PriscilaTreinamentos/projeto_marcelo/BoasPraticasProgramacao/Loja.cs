namespace BoasPraticasProgramacao
{
    public class Loja : TotalCompras
    {
        int totalCompra = 0;
        public void comprar(int totalCompra)
        {
            this.totalCompra += totalCompra;
        }

        public int totalCompras()
        {
            return totalCompra;
        }
    }
}
