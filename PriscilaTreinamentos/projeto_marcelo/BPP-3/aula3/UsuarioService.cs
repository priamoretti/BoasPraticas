using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_3.aula3
{
    public class UsuarioService
    {
        BancoDadosUsuario bancoDadosUsuario = new BancoDadosUsuario();
        ValidadorUsuario validadorUsuario = new ValidadorUsuario();
        CalculadoraPagamento calculadoraPagamento = new CalculadoraPagamento();

        public void salvarUsuario(Usuario usuario)
        {
            validadorUsuario.validacaoUsuario(usuario);
            calculadoraPagamento.calcular(usuario.pagamento, usuario.salario);
            bancoDadosUsuario.adicionar(usuario);
            Console.WriteLine("USUARIO SALVO COM SUCESSO");
        }        

    }
}
