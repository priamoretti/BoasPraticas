using System;
using aula1;
using BoasPraticasProgramacao;
using BPP_2.aula3;
using BPP_2.aula4;


namespace BPP_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ParametrosPagamento parametrosPagamento = new ParametrosPagamento();
            //parametrosPagamento.idade = 10;
            //parametrosPagamento.salario = 10;
            //parametrosPagamento.nome = "teste";

            //CalculadoraPagamento calculadoraPagamento = new CalculadoraPagamento(parametrosPagamento);
            //float salarioFuncionario = calculadoraPagamento.retornaCalculoFuncionario();            
            //Console.WriteLine("salario " + salarioFuncionario);

            //var funcionario = new Funcionario();

            //var cadastrar = new TvServico();
            //Microsoft.CodeAnalysis.Optional<Televisao> optional = cadastrar.buscar(5);
            //if (optional.HasValue)
            //{
            //    Televisao tv = optional.Value;
            //    // processaemnto.
            //}

            //// exemplo de acoplamento temporal.            
            //ValidacaoOk validacaoOk =  validar(funcionario);
            //SalvarOk salvarOk =  salvarFuncionario(funcionario,validacaoOk);
            //registarLogFuncionario(funcionario,salvarOk);
            //
            //exemplo principio do aberto e fechado

            //CalculadoraPagamentoSalario calculadoraPagamentoSalario = new CalculadoraPagamentoSalario();
            //PagamentoProgramador pagamentoProgramador = new PagamentoProgramador();
            //float salario = calculadoraPagamentoSalario.calcular(pagamentoProgramador, 500f);
            //Console.WriteLine("salario programador: " + salario);

            //AnalistaPagamento analistaPagamento = new AnalistaPagamento();
            //salario = calculadoraPagamentoSalario.calcular(analistaPagamento, 600f);
            //Console.WriteLine("salario analista: " + salario);

            //TestadorPagamento testadorPagamento = new TestadorPagamento();
            //salario = calculadoraPagamentoSalario.calcular(testadorPagamento, 800f);
            //Console.WriteLine("salario testador: " + salario);

            //Usuario usuario = new Usuario();
            //usuario.cargo = "DIRETOR";
            //usuario.nome = "pedro";
            //usuario.salario = 1000f;
            //UsuarioServico usuarioServico = new UsuarioServico();
            //PagamentoDiretor pagamentoDiretor = new PagamentoDiretor();
            //float salarioDiretor = calculadoraPagamentoSalario.calcular(pagamentoDiretor, usuario.salario);
            //Console.WriteLine("salario diretor: " + salario);
            //usuarioServico.salvarUsuario(usuario);

            //Telefone telefone = null;
            //IPhone phone = new IPhone();
            //Nokia5120 nokia5120 = new Nokia5120();

            //telefone = phone;
            //telefone.enviarMensagem();
            //telefone.receberMensagem();
            //telefone.ligar();

            //telefone = nokia5120;
            //telefone.enviarMensagem();
            //telefone.receberMensagem();
            //telefone.ligar();

            //Baleia baleia = new Baleia();
            //Cachorro cachorro = new Cachorro();
            //testaBixo(baleia);
            //testaBixo(cachorro);
            BancoDadosMysql bancoDadosMysql = new BancoDadosMysql();
            PersistenciaPassagemBancoDados persistenciaPassagemBancoDados =
                            new PersistenciaPassagemBancoDados(bancoDadosMysql);

            PersistenciaPassagemImpl persistenciaPassagemImpl =
                            new PersistenciaPassagemImpl(persistenciaPassagemBancoDados);

            persistenciaPassagemImpl.persistir(new Passagem());

            persistenciaPassagemImpl.persistenciaPassagem = new PersistenciaPassagemAPI();
            persistenciaPassagemImpl.persistir(new Passagem());

            persistenciaPassagemImpl.persistenciaPassagem = new PersistenciaPassagemLocal();
            persistenciaPassagemImpl.persistir(new Passagem());

            BoasPraticasProgramacao.Calculadora calculadora = new BoasPraticasProgramacao.Calculadora(new LogImplA());
            calculadora.somar(2, 6);

            calculadora.log = new LogImplB();
            calculadora.somar(3, 8);

        }

        public static void testaBixo(Bixo bixo)
        {
            if(bixo is Baleia)
            {
                Baleia baleia = (Baleia)bixo;
                baleia.nadar();
            }
            if (bixo is Cachorro)
            {
                Cachorro cachorro = (Cachorro)bixo;
                cachorro.caminhar();
                cachorro.nadar();
            }

        }

        public static ValidacaoOk validar(Funcionario funcionario)
        {
            // vlaidar..bkkdkdkdkdkd
            return new ValidacaoOk();
        }

        public static SalvarOk salvarFuncionario(Funcionario funcionario, ValidacaoOk validacaoOk)
        {
            // vlaidar..bkkdkdkdkdkd
            return new SalvarOk();
        }

        public static void registarLogFuncionario(Funcionario funcionario,SalvarOk salvarOk)
        {
            // vlaidar..bkkdkdkdkdkd
        }

    }
}
