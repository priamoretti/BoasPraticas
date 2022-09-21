using System;

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
            var retorno = processaEditarFuncionarario(funcionario);
            return retorno;
        }
        public int processaEditarFuncionarario(Funcionario f)
        {
            // processa a edicao do funcionario.
            var sucessoEdicao = true;
            if (sucessoEdicao)
            {
                return -1; // sucesso
            }
            else
            {
                return -1; // error na edicao.
            }
        }
        private void ValidaFuncionario(Funcionario funcionario)
        {
            //if (funcionario.id == 0)
            //{
            //    throw new Exception("Funcionario deve ter um ID");
            //}
        }
    }
}
