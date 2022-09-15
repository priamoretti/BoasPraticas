using PriscilaTreinamentos.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriscilaTreinamentos
{
    public class Professor : CalculaSalario
    {
        public float calculaSalario(float Salario)
        {
            return (Salario * 5) + Salario;
        }

    }
}
