using ExercicioPagamento.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPagamento
{
    public class Venda
    {
        public Models.Enums.Pagamento formapagamento;
        FabricaPagamento fabrica = new FabricaPagamento();
        IPagamentos pagamento = null;
        FormasDePagamento formasDePagamento = new FormasDePagamento();
        public void PreencherDados()
        {
            Console.WriteLine("Preencha o nome do comprador:");
            Console.ReadLine();
            Console.WriteLine("Preeencha a forma de pagamento");
            Console.ReadLine();
            foreach (var elemento in Enum.GetValues(typeof(Models.Enums.Pagamento)))
            {
                Console.WriteLine(elemento.ToString());
            }
            formapagamento = (Models.Enums.Pagamento)Convert.ToInt32(Console.ReadLine());
            Uteis.ValidarOpcaoEnum(formapagamento);
            pagamento = fabrica.CriarTipoPagamento((int)formapagamento);
            var teste = pagamento.ColetarDados();
            
;        }



       
    }
}
