using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoLiskov.Passagem
{
    public class Oracle : IBancoDados
    {
        public void Salvar(Passagem1 passagem)
        {
            Console.WriteLine("SALVANDO oracle");
        }
    }
}
