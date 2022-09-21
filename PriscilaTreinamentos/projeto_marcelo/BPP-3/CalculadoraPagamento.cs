using System;
using BPP_3;

namespace BoasPraticasProgramacao
{
    class CalculadoraPagamento
    {
        float resultadoFinal = 0;
        public CalculadoraPagamento(ParametrosCalculadoraPagamento parametrosCalculadoraPagamento)
        {
            var funcionario = new Funcionario();
            funcionario.dataNascimento = parametrosCalculadoraPagamento.dataNascimento;
            funcionario.idade = parametrosCalculadoraPagamento.idade;
            funcionario.nome = parametrosCalculadoraPagamento.nome;
            funcionario.salario = parametrosCalculadoraPagamento.salario;
            try
            {
                validaFuncionario(funcionario);
                resultadoFinal = calcular(funcionario);
            }
            catch (Exception)
            {
                Console.WriteLine("errro na validação");
            }

        }

        private void validaFuncionario(Funcionario funcionario)
        {
            if (eFuncionarioInvalido(funcionario))
            {
                throw new Exception("error funcionario");
            }
        }

        private static bool eFuncionarioInvalido(Funcionario funcionario)
        {
            return funcionario.nome.Equals("") || funcionario.idade == 0;
        }


        private float calcular(Funcionario funcionario)
        {
            float resultado = 0;
            var eSalarioFuncionarioJunior = funcionario.salario < 1000;
            var eSalarioFuncionarioSenior = funcionario.salario > 1000;
            var ACRESCIMENTO_SALARIO_JUNIOR = 0.1f;
            var ACRESCIMENTO_SALARIO_SENIOR = 0.2f;

            if (eSalarioFuncionarioJunior)
            {
                resultado = (funcionario.salario * ACRESCIMENTO_SALARIO_JUNIOR) + funcionario.salario;
            }
            if (eSalarioFuncionarioSenior)
            {
                resultado = (funcionario.salario * ACRESCIMENTO_SALARIO_SENIOR) + funcionario.salario;
            }

            return resultado;
        }

        public float retornaCalculoFuncionario()
        {
            return resultadoFinal;
        }

    }
}

