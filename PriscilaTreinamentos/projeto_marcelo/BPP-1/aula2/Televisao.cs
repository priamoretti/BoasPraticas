using System;

namespace BoasPraticasProgramacao
{
    public class Televisao
    {
        public String nome { get; set; } 
        public int tamanho { get; set; } 

        public Televisao(String nome, int tamanho)
        {
           
            validarTv(nome, tamanho);
            // buscar alguma coisa
            this.nome = nome;
            this.tamanho = tamanho;
           
        }
                
        private void validarTv(String nome, int tamanho)
        {
            var eParametroInvalidTv = nome.Equals("") || (tamanho < 0 || tamanho > 100);
            if (eParametroInvalidTv)
            {
                throw new Exception("Parametros da tv estao invalidos"); 
            }
            // faz alguma coisa
        }

        
    }
}
