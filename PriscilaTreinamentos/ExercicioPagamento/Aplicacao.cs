using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPagamento
{
    public class Aplicacao
    {
        public void RodarAplicacao()
        {
            ChamarServidor();
            ChamarVenda();

        }
        
        public void ChamarServidor() {
            Servidor servidor = new Servidor();
            servidor.EscolherServidor();
        }

        public void ChamarVenda()
        {
            Venda venda = new Venda();
            venda.PreencherDados();
        }
    }
}
