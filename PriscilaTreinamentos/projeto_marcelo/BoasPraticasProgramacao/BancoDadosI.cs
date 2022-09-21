using System;

namespace BoasPraticasProgramacao
{
    public interface BancoDadosI
    {
        void salvar();
        void remover();
    }

    public class BancoDadosOracle : BancoDadosI
    {
        public void remover()
        {
            Console.WriteLine("removendo dados: banco de dados oracle");
        }

        public void salvar()
        {
            Console.WriteLine("salvando dados: banco de dados oracle");
        }
    }

    public class BancoDadosSqlServer : BancoDadosI
    {
        public void remover()
        {
            Console.WriteLine("removendo dados: banco de dados SqlServer");
        }

        public void salvar()
        {
            Console.WriteLine("salvando dados: banco de dados SqlServer");
        }
    }

}
