using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_2.aula3
{
    public class PessoaServico
    {
        ValidadorPessoa validadorPessoa = new ValidadorPessoa();
        BancoDadosPessoa bancoDadosPessoa = new BancoDadosPessoa();

        public void salvar(Pessoa pessoa)
        {
            validadorPessoa.validar(pessoa);
            bancoDadosPessoa.salvar(pessoa);
        }
    }
}
