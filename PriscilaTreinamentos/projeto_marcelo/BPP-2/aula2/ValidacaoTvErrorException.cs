using System;

namespace BPP_2.aula2
{
    public class ValidacaoTvErrorException : Exception
    {
        public ValidacaoTvErrorException(string message) : base(message) { }
    }
}
