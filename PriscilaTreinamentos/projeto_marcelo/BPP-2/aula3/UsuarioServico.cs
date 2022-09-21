using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_2.aula3
{
    public class UsuarioServico
    {
        List<Usuario> lista = new List<Usuario>();
        ValidacaoUsuario validacaoUsuario = new ValidacaoUsuario();

        public void salvarUsuario(Usuario usuario)
        {
            validacaoUsuario.validacaoUsuario(usuario);            
            lista.Add(usuario);
            Console.WriteLine("usuario salvo com sucesso");
        }       

    }
}
