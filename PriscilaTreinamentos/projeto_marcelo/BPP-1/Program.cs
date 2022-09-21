using System;
using aula1;
using BoasPraticasProgramacao;
using BPP_1.aula2;
using BPP_1.aula3;
using BPP_1.aula4;
using Microsoft.CodeAnalysis;

namespace BPP_1
{
    public class Program
    {
        static void Main(string[] args)
        {

            //var calculadoraPagamento = new CalculadoraPagamento("maria", 30, "26/06/1990", 500);
            //var resultado = calculadoraPagamento.retornaCalculoFuncionario();
            //Console.WriteLine("salário: " + resultado);

            //var bilheteServico = new BilheteServico();
            //var bilhete = bilheteServico.buscarBilhete(2);
            //Console.WriteLine(bilhete.descricao);

            //TvServico tvServico = new TvServico();
            //Optional<Televisao> optTv =  tvServico.buscarTelevisao("sony");            
            //if (optTv.HasValue)
            //{
            //    Televisao tv = optTv.Value;
            //    Console.WriteLine(tv.nome);
            //}
            //try
            //{
            //    tvServico.adicionar(new Televisao("cce", 32));
            //    Console.WriteLine("Tv cadastrada com sucesso.");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Error ao salvar a tv");
            //    Console.WriteLine(e.StackTrace);                
            //}

            //Pessoa pessoa = new Pessoa();

            //ValidaPessoa validaPessoa = new ValidaPessoa();
            //BancoDadosPessoa bancoDados = new BancoDadosPessoa();
            //validaPessoa.validar(pessoa);
            //bancoDados.salvarPessoa(pessoa);

            //ProcessaPagamento processaPagamento = new ProcessaPagamento();
            //ProgramadorPagamento programadorPagamento = new ProgramadorPagamento();
            //float salario = processaPagamento.
            //                    processarCalculo(programadorPagamento, 100f);

            //Console.WriteLine("salario do programador " + salario);

            //AnalistaPagamento analistaPagamento = new AnalistaPagamento();
            //salario = processaPagamento.
            //                    processarCalculo(analistaPagamento, 200f);
            //Console.WriteLine("salario do analista " + salario);

            //TestadorPagamento testadorPagamento = new TestadorPagamento();
            //salario = processaPagamento.processarCalculo(testadorPagamento, 50);
            //Console.WriteLine("salario do testador " + salario);

            //UsuarioService usuarioService = new UsuarioService();
            //Usuario usuario = new Usuario();
            //usuario.salario = 500f;
            //usuario.pagamento = new ProfessorPagamento();
            //usuario.id = 5;

            //usuarioService.salvarECalcularPagamento(usuario, new ProfessorPagamento());            

            Bixo bixo = null;
            Cachorro cachorro = new Cachorro();
            Baleia baleia = new Baleia();
            executarBixo(baleia);
            executarBixo(cachorro);

            IPhone13 phone13 = new IPhone13();
            Nokia5120 nokia5120 = new Nokia5120();
            
            phone13.conectarInternet();
            phone13.enviarMensagem();
            phone13.receberMensagem();
            phone13.ligar();
            
            nokia5120.enviarMensagem();
            nokia5120.receberMensagem();
            nokia5120.ligar();

            MylsqlBancoDAdos mylsqlBancoDAdos = new MylsqlBancoDAdos();
            LocalBancoDados localBancoDados = new LocalBancoDados();
            SyBaseBancoDados syBaseBancoDados = new SyBaseBancoDados();

            Sistema sistema = new Sistema(localBancoDados);
            sistema.salvar(new Passagem());

            sistema.bancoDados = mylsqlBancoDAdos;
            sistema.salvar(new Passagem());

            sistema.bancoDados = syBaseBancoDados;
            sistema.salvar(new Passagem());

            Log4J log4J = new Log4J();
            LogPorConsole logPorConsole = new LogPorConsole();

            aula4.Calculadora calculadora = new aula4.Calculadora(log4J);
            int resultado = calculadora.somar(5, 4);
            Console.WriteLine("soma: " + resultado);

            calculadora.log = logPorConsole;
            resultado = calculadora.somar(3, 2);
            Console.WriteLine("soma: " + resultado);

        }

        public static void executarBixo(Bixo bixo)
        {
            if(bixo is BixoCaminha)
            {
                BixoCaminha bixoCaminha = (BixoCaminha)bixo;
                bixoCaminha.caminhar();
            }
            if(bixo is BixoNada)
            {
                BixoNada bixoNada = (BixoNada)bixo;
                bixoNada.nadar();
            }
        }

    }
}
