using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_3.aula3
{

    class BancoDadosUsuario
    {
        List<Usuario> lista = new List<Usuario>();

        public void adicionar(Usuario usuario)
        {
            this.lista.Add(usuario);
        }
    }
}
