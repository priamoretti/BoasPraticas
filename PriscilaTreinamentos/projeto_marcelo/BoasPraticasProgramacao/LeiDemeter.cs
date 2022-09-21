using System;

namespace BoasPraticasProgramacao
{
    class LeiDemeter
    {
        public void errado()
        {
            FolhaPagamento folhaPagamento = new FolhaPagamento();
            String nomeFuncionario = folhaPagamento.funcionario.no; // errado
        }

        public void correto()
        {
            FolhaPagamento folhaPagamento = new FolhaPagamento();
            Funcionario funcionario = folhaPagamento.funcionario;
            String nomeFuncionario = funcionario.no; // correto.

            fazAlgumaCoisa(); // correto
        }

        public void fazAlgumaCoisa()
        {
        }


    }
}
