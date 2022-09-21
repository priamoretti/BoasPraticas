using System;


namespace aula1
{
    class CalculadoraPagamento
    {
        float resultadoFinal = 0;
        float ACRESCIMENTO_PARA_JUNIOR = 0.1f;
        float ACRESCIMENTO_PARA_SENIOR = 0.1f;

        public CalculadoraPagamento(ParametrosPagamento parametrosPagamento)
        {
            var funcionario = new Funcionario();
            funcionario.dataNascimento = parametrosPagamento.dataNascimento;
            funcionario.idade = parametrosPagamento.idade;
            funcionario.nome = parametrosPagamento.nome;
            funcionario.salario = parametrosPagamento.salario;
            try
            {
                validarFuncionario(funcionario);
                resultadoFinal = calcularSalario(funcionario);
            }
            catch (Exception)
            {
                Console.WriteLine("errro na validação");
            }

        }

        private void validarFuncionario(Funcionario f)
        {
            if (eFuncionarioInvalido(f))
            {
                throw new Exception("error funcionario");
            }
        }

        private bool eFuncionarioInvalido(Funcionario f)
        {
            return f.nome.Equals("") || f.salario == 0;
        }


        private float calcularSalario(Funcionario funcionario)
        {
            float resultado = 0;
            var eFuncionarioJunior = funcionario.salario < 1000;
            var eFuncionarioSenior = funcionario.salario > 1000;

            if (eFuncionarioJunior)
            {
                resultado = (funcionario.salario * ACRESCIMENTO_PARA_JUNIOR) + funcionario.salario;
            }
            if (eFuncionarioSenior)
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

