using System;
using System.Collections.Generic;
using System.Text;

namespace BoasPraticasProgramacao.Strategy.Exercicio
{
    public class MeiosDePagamentoContexto
    {
        public MeiosDePagamento GetStrategy(string tipoPagamento)
        {
            if (tipoPagamento.Equals("Dinheiro"))
            {
                return new DinheiroStrategy();
            }

            if (tipoPagamento.Equals("PIX"))
            {
                return new PixStrategy();
            }

            if (tipoPagamento.Equals("Cartão de débito"))
            {
                return new CartaoDeDebitoStrategy();
            }

            if (tipoPagamento.Equals("Cartão de crédito"))
            {
                return new CartaoDeCreditoStrategy();
            }

            throw new Exception("Meio de pagamento inválido");
        }

        public void Pagar(string tipoPagamento, double valor)
        {
            if (tipoPagamento.Equals("Dinheiro"))
            {
                double pagamento = new DinheiroStrategy().Pagar(valor);
                Console.WriteLine("---------- PAGAMENTO EM DINHEIRO ----------");
                Console.WriteLine("Desconto de 5%");
                Console.WriteLine("Novo valor de: R$" + pagamento);
                Console.WriteLine("Abrindo caixa");
                Console.WriteLine("Pagamento efetuado com sucesso");

            }

            if (tipoPagamento.Equals("PIX"))
            {
                double pagamento =  new PixStrategy().Pagar(valor);
                Console.WriteLine("---------- PAGAMENTO EM PIX ----------");
                Console.WriteLine("Efetuando pix no valor de: R$" + valor);
                Console.WriteLine("Informando banco central");
                Console.WriteLine("Operação efetuada com sucesso");
            }

            if (tipoPagamento.Equals("Cartão de débito"))
            {
                double pagamento = new CartaoDeDebitoStrategy().Pagar(valor);
                Console.WriteLine("---------- PAGAMENTO EM DÉBITO ----------");
                Console.WriteLine("Efetuando conexão");
                Console.WriteLine("Valor pago" + pagamento);
                Console.WriteLine("Imprimindo comprovante");
            }

            if (tipoPagamento.Equals("Cartão de crédito"))
            {
                double pagamento = new CartaoDeCreditoStrategy().Pagar(valor);
                Console.WriteLine("---------- PAGAMENTO EM CRÉDITO ----------");
                Console.WriteLine("Efetuando conexão");
                Console.WriteLine("Valor pago: " + pagamento);
                Console.WriteLine("Impimindo comprovante");
            }
        }
    }
}
