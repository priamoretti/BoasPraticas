namespace BoasPraticasProgramacao
{
    public class NaRua : TotalCompras
    {

        int totalCompra = 0;

        public void realizandoCompra(int totalCompra)
        {
            this.totalCompra += totalCompra;
        }

        public int totalCompras()
        {
            return totalCompra;
        }
    }
}
