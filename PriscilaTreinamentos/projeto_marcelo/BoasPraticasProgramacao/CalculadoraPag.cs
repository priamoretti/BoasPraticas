using System;

namespace BoasPraticasProgramacao
{
    class CalculadoraPag
    {
        float resu = 0; // resultado final
        public CalculadoraPag(string nome, int idade, string dataNascimento, float salario)
        {
            Funcionario f = new Funcionario();
            f.dt = dataNascimento;
            f.idade = idade;
            f.no = nome;
            f.s = salario;
            try
            {
                validaFuncionario(f);
            }
            catch (Exception)
            {
                Console.WriteLine("errro na validação");
            }
            resu = calcula(f);
        }

        private void validaFuncionario(Funcionario f)
        {
            if (f.no.Equals("") || f.idade == 0)
            {
                throw new Exception("error funcionario");
            }
        }

        // esse metodo calcula o salario do funcionario
        private float calcula(Funcionario f)
        {
            float r = 0;
            if (f.s < 1000)
            {
                r = (f.s * 0.1f) + f.s;
            }
            if (f.s > 1000)
            {
                r = (f.s * 0.2f) + f.s;
            }

            return r;
        }

        public float retornaCalculoFuncionario()
        {
            return resu;
        }

    }
}

