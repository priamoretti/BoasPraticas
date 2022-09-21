namespace BoasPraticasProgramacao
{
    public class Internet : TotalCompras
    {
        int totalCompra = 0;
        public void realizaCompra(int totalCompra)
        {
            this.totalCompra += totalCompra;
        }

        public int totalCompras()
        {
            return totalCompra;
        }
    }




}
