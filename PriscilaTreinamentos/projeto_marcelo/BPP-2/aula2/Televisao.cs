using BPP_2.aula2;

namespace BoasPraticasProgramacao
{
    public class Televisao
    {
        public string nome { get; set; }
        public int tamanho { get; set; }

        public Televisao(string nome, int tamanho)
        {
            valida(nome, tamanho);
            this.nome = nome;
            this.tamanho = tamanho;
        }

        private void valida(string nome, int tamanho)
        {
            var isErrorPametros = nome.Equals("") || (tamanho < 0 || tamanho > 100);
            if (isErrorPametros)
            {
                throw new ValidacaoTvErrorException("Tv contem paraemtros invalidos");
            }

        }
    }
}
