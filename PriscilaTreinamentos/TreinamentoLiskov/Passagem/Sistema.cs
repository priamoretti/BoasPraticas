using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoLiskov.Passagem
{
    public class Sistema
    {
        public IBancoDados bancodedados { get; set; }
        public void Salvar(Passagem1 passagem)
        {
            bancodedados.Salvar(passagem);
            
        }
    }
}
