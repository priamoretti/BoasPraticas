using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPagamento.Models
{
    public class FormasDePagamento
    {
        public class FormaDinheiro
        {
            public decimal valor { get; set; }
            public FormaDinheiro()
            { }

            public FormaDinheiro(decimal valor)
            {
                this.valor = valor;
            }
        }

        public class FormaCartaoDebito
        {
            public decimal valor { get; set; }
            public FormaCartaoDebito()
            { }

            public FormaCartaoDebito(decimal valor)
            {
                this.valor = valor;
            }
        }


        public class FormaCartaoCredito
        {
            public decimal valor { get; set; }
            public FormaCartaoCredito()
            { }

            public FormaCartaoCredito(decimal valor)
            {
                this.valor = valor;
            }
        }


        public class Pix
        {
            public decimal valor { get; set; }
            public Pix()
            { }

            public Pix(decimal valor)
            {
                this.valor = valor;
            }
        }
    }
}
