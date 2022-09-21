using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.CodeAnalysis;

namespace BPP_1.aula3
{
    public class UsuarioService 
    {

        List<Usuario> lista = new List<Usuario>();
        ProcessaPagamento processaPagamento = new ProcessaPagamento();
        ValidacaoUsuario validacaoUsuario = new ValidacaoUsuario();

        public void salvarECalcularPagamento(Usuario usuario,Pagamento pagamento)
        {
            Optional<Usuario> optUsuario =  validacaoUsuario.validar(usuario);
            if (optUsuario.HasValue)
            {
                float salario = processaPagamento.processarCalculo(pagamento, usuario.salario);
                lista.Add(usuario);
                Console.WriteLine("salario: " + salario + " adicionado com sucesso usuario");
            }
            else
            {
                throw new Exception("Ocorreu um erro ao salvar o usuario " + usuario.ToString());
            }
            

        }
    }
}
