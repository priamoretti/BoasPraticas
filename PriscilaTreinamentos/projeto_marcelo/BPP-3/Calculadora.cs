namespace BPP_3
{
    class Calculadora
    {
        public int somar(int valorA, int valorB)
        {
            return valorA + valorB;
        }

        public void subtrair(int valorA, int valorB, bool comVirgula)
        {
            if (comVirgula)
            {
                // faz alguma coisa
            }
            else
            {
                // faz outra coisa
            }
        }

        public void subtrairSemVirgula(int valorA, int valorB)
        {

        }

        /* public void subtrairComVirgula(int valorA, int valorB)
         {

         }*/

        public int buscarChave(int idChave)
        {
            if (string.IsNullOrEmpty(idChave.ToString()))
            {
                throw new IdNaoEncontradoException("Id da chave e invalida");
            }

            // processa a busca da chave.
            return 50;
        }

    }
}
