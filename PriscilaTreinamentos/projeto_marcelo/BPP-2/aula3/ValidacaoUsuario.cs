using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_2.aula3
{
    public class ValidacaoUsuario
    {
        public void validacaoUsuario(Usuario usuario)
        {
            if (usuario == null)
            {
                throw new Exception("usuario está null");
            }
            if (usuario.nome.Equals(""))
            {
                throw new Exception("nome em branco");
            }
        }
    }
}
