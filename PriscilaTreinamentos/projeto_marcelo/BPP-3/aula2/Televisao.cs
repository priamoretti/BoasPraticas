using System;

namespace BoasPraticasProgramacao
{
    public class Televisao
    {
        public String nome { get; set; }
        public int tamanho { get; set; }

        public Televisao(String nome, int tamanho)
        {
            validar(nome, tamanho);
            this.nome = nome;
            this.tamanho = tamanho;
        }


        private void validar(String nome, int tamanho)
        {
            if (temNomeInvalidoTv(nome) || eTamanhoInvalidoTv(tamanho))
            {
                throw new Exception("Error com os parametros da tv");
            }
        }

        private static bool eTamanhoInvalidoTv(int tamanho)
        {
            return (tamanho < 0 || tamanho > 100);
        }

        private static bool temNomeInvalidoTv(string nome)
        {
            return nome.Equals("");
        }
    }
}
