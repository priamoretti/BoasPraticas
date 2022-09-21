namespace BoasPraticasProgramacao
{
    class CalculaPagameto
    {
        public float calcular(Funcionario funcionario)
        {
            if (funcionario.tipo.Equals("PROGRAMADOR"))
            {
                return funcionario.salario * 0.20f;
            }
            if (funcionario.tipo.Equals("ANALISTA"))
            {
                return funcionario.salario * 0.30f;
            }

            return -1;
        }
    }
}



