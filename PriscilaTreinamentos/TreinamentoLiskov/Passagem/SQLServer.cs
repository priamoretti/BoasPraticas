using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoLiskov.Passagem
{
    public class SQLServer : IBancoDados
    {
        public void Salvar(Passagem1 passagem)
        {
            Console.WriteLine("Salvando SQL Server");
        }
    }
}
