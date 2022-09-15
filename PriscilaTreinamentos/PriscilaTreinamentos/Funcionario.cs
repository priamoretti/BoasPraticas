


namespace BoasPraticasProgramacao
{
    public class Funcionario
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string DataNascimento { get; set; }
        public float Salario { get; set; }
        public string Tipo { get; set; }
        
    }

    enum EditarFuncionarioRetorno
    {
        Sucesso = 1,
        Erro = -1
    }

}