using System;
using aula1;
using BPP_1.aula2;
namespace BoasPraticasProgramacao
{

    class FuncionarioService
    {
        Funcionario funcionario { get; set; }

        public int editarFuncionario(Funcionario funcionario)
        {
            try
            {
                ValidaFuncionario(funcionario);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return processaEditarFuncionarario(funcionario);
        }
        public int processaEditarFuncionarario(Funcionario funcionario)
        {
            var sucessoEdicao = true;
            if (sucessoEdicao)
            {
                return ((int)EnumRetorno.SUCESSO);
            }
            else
            {
                throw new Exception(EnumRetorno.ERRO.ToString());
            }
        }
        private void ValidaFuncionario(Funcionario funcionario)
        {
            var eIdInvalido = funcionario.id == 0;
            if (eIdInvalido)
            {
                throw new Exception("Funcionario deve ter um ID");
            }
        }
    }


}
