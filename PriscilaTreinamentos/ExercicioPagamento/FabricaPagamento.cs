using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;
using static ExercicioPagamento.Models.FormasDePagamento;

namespace ExercicioPagamento
{
    public class FabricaPagamento
    {
        public <T>IPagamentos CriarTipoPagamento(int numero)
        {
                switch (numero)
                {
                    case 1:
                        return new Dinheiro();

                    case 2:
                        return new Pix();
                    case 3:
                        return new CartaoCredito();

                    case 4:
                        return new CartaoDebito();
                default:
                    return new CartaoDebito();
                }
        }

    }
}
