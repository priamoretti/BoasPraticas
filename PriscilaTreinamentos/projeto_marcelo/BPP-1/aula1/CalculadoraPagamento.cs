using System;

namespace aula1
{
    class CalculadoraPagamento
    {
        float resultadoFinal = 0;
        public CalculadoraPagamento(string nome, int idade, string dataNascimento, float salario)
        {
            var funcionario = new Funcionario();
            funcionario.dataNascimento = dataNascimento;
            funcionario.idade = idade;
            funcionario.nome = nome;
            funcionario.salario = salario;
            try
            {
                validaFuncionario(funcionario);
                resultadoFinal = calcularSalario(funcionario);
            }
            catch (Exception i)
            {
                Console.WriteLine("errro na validação" + i.StackTrace);
            }

        }

        private void validaFuncionario(Funcionario funcinario)
        {
            if (eInvalidoFuncionario(funcinario))
            {
                throw new Exception("error funcionario");
            }
        }

        private bool eInvalidoFuncionario(Funcionario funcinario)
        {
            return funcinario.nome.Equals("") || funcinario.idade == 0;
        }


        private float calcularSalario(Funcionario funcionario)
        {
            float resultado = 0;
            var isSalarioJunior = funcionario.salario < 1000;
            var isSalarioSenior = funcionario.salario > 1000;
            var ACRESCIMENTO_PARA_JUNIOR = 0.1f;
            var ACRESCIMENTO_PARA_SENIOR = 0.2f;

            if (isSalarioJunior)
            {
                resultado = (funcionario.salario * ACRESCIMENTO_PARA_JUNIOR) + funcionario.salario;
            }
            if (isSalarioSenior)
            {
                resultado = (funcionario.salario * ACRESCIMENTO_PARA_SENIOR) + funcionario.salario;
            }

            return resultado;
        }

        public float retornaCalculoFuncionario()
        {
            return resultadoFinal;
        }

    }
}

