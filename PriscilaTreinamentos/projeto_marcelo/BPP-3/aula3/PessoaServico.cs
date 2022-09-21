using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_3.aula3
{
    public class PessoaServico
    {
        BancoDadosPessoa bancoDadosPessoa = new BancoDadosPessoa();
        ValidadorPessoa validadorPessoa = new ValidadorPessoa();

        public void salvar(Pessoa pessoa)
        {
            validadorPessoa.validar(pessoa);
            bancoDadosPessoa.salvarPessoa(pessoa);
        }
    }
}
