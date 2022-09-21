namespace BoasPraticasProgramacao
{
    public class BancoDadosImpl
    {
        public BancoDadosI bancoDados { get; set; }

        public BancoDadosImpl(BancoDadosI bancoDados)
        {
            this.bancoDados = bancoDados;
        }

        public void salvando()
        {
            bancoDados.salvar();
        }

        public void removendo()
        {
            bancoDados.remover();
        }
    }


}
