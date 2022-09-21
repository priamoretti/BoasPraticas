using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_2.aula3
{
    public class BancoDadosPessoa
    {
        public void salvar(Pessoa pessoa)
        {
            if(pessoa == null)
            {
                throw new Exception("Pessoa invalida, esta null");
            }
            string sql = "insert into PESSOA blablabalabal where";
            if (pessoa.nome.StartsWith("m"))
            {
                sql += " nome == dbkbkkbkakakbkb";
            }
            if (pessoa.nome.StartsWith("x"))
            {
                sql += " nome == XXXX";
            }
            // CONEXAO.INSERT(sql);
        }
    }
}
