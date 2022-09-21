using System;

namespace BPP_3
{
    public class IdNaoEncontradoException : Exception
    {
        public IdNaoEncontradoException(string message) : base(message)
        {
        }
    }
}
