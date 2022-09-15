using System;
using System.Collections.Generic;
using System.Text;

namespace BoasPraticasProgramacao
{

    
    class FuncionarioService
    {
        Funcionario funcionario { get; set; }
        public int EditarFuncionario(Funcionario funcionario)
        {
            try
            {
                ValidarFuncionario(funcionario);                
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return processaEditarFuncionario(funcionario);
        }
        public int processaEditarFuncionario(Funcionario funcionario)
        {
            // processa a edicao do funcionario.
            bool SucessoEdicao = true;
            if (SucessoEdicao)
            {
                return Convert.ToInt32(EditarFuncionarioRetorno.Sucesso.ToString());
            }
            else
            {
                return Convert.ToInt32(EditarFuncionarioRetorno.Erro.ToString());
            }
        }
        private void ValidarFuncionario(Funcionario funcionario)
        {
            if(FuncionarioSemId(funcionario))
            {
                throw new Exception("Funcionario deve ter um ID");
            }            
        }

        private bool FuncionarioSemId(Funcionario funcionario)
        {
            return funcionario.id == 0;
        }
    }


}
