using System;
using System.Collections.Generic;
using System.Text;

namespace BoasPraticasProgramacao.BPP_3.aula8
{
    public class FacadePedido
    {
        ModuloEstoque moduloEstoque = new ModuloEstoque();
        ModuloFinanceiro moduloFinanceiro = new ModuloFinanceiro();
        ModuloPosVenda moduloPosVenda = new ModuloPosVenda();

        public void executarPedido(Pedido pedido)
        {
            moduloEstoque.enviarPedido(pedido);
            moduloFinanceiro.Faturar(pedido);
            moduloPosVenda.EnviarMensagemParaCliente(pedido);

        }
    }
}
