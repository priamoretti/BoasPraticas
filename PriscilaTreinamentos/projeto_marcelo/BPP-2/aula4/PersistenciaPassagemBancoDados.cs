using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_2.aula4
{
    public class PersistenciaPassagemBancoDados : PersistenciaPassagem
    {
        BancoDados bancoDados;

        public PersistenciaPassagemBancoDados(BancoDados bancoDados)
        {
            this.bancoDados = bancoDados;
            bancoDados.conectar();
            bancoDados.monitorar();
        }

        public void persisitir(Passagem passagem)
        {
            Console.WriteLine("salvando passagem no banco de dados MY_SQL");
        }
    }
}
