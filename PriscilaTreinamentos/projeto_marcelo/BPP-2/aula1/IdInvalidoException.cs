using System;

namespace aula1
{
    public class IdInvalidoException : Exception
    {

        public int codigoError { get; set; }
        public string descricao { get; set; }

        public IdInvalidoException(int codigoError, string descricao)
        {
            this.codigoError = codigoError;
            this.descricao = descricao;
        }
    }
}
