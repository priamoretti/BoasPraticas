using System;
using BoasPraticasProgramacao;
using BPP_3.aula3;
using BPP_3.aula4;
using BPP_3.PizzaBuilder;
using Microsoft.CodeAnalysis;
using CalculadoraPagamento = BPP_3.aula3.CalculadoraPagamento;

namespace BPP_3
{
    class Program
    {
        static void Main(string[] args)
        {


            //var pinPad = buscar(-1);
            //Console.WriteLine(pinPad.id);

            //var optPinPad = buscar2(2);
            //if (optPinPad.HasValue)
            //{
            //    PinPad pinPad2 = optPinPad.Value;
            //}

            // -----------------

            //var validacaoOK = validar(pinPad);
            //var salvarOK = salvar(pinPad, validacaoOK);
            //logSAlvarPinPad(pinPad, salvarOK);

            //TvServico tvServico = new TvServico();
            //Optional<Televisao> opttelevisao = tvServico.buscarTelevisao("sony");
            //if (opttelevisao.HasValue)
            //{
            //    Televisao tv = opttelevisao.Value;
            //    Console.WriteLine("tv encontrada sony");
            //}
            //else
            //{
            //    Console.WriteLine("tv não foi encontrada");
            //}

            //Televisao tvParInserir = new Televisao("cce", 20);
            //tvServico.adicionar(tvParInserir);
            //opttelevisao = tvServico.buscarTelevisao("cce");
            //if (opttelevisao.HasValue)
            //{
            //    Televisao tv = opttelevisao.Value;
            //    Console.WriteLine("tv encontrada cce");
            //}
            //else
            //{
            //    Console.WriteLine("tv não foi encontrada");
            //}

            //CalculadoraPagamento calculadoraPagamento = new CalculadoraPagamento();

            //AnalistaPagamento analistaPagamento = new AnalistaPagamento();
            //float salario = calculadoraPagamento.calcular(analistaPagamento, 1000f);
            //Console.WriteLine("salario do analista é: " + salario);

            //ProgramadorPagamento programadorPagamento = new ProgramadorPagamento();
            //salario = calculadoraPagamento.calcular(programadorPagamento, 500f);
            //Console.WriteLine("salario do programador é: " + salario);

            //TestadorPagamento testadorPagamento = new TestadorPagamento();
            //salario = calculadoraPagamento.calcular(testadorPagamento, 800f);
            //Console.WriteLine("salario do testador é: " + salario);

            //    Usuario usuario = new Usuario();
            //    usuario.cargo = "professor";
            //    usuario.nome = "pedro";
            //    usuario.salario = 1000f;
            //    usuario.pagamento = new ProfessorPagamento();

            //    UsuarioService usuarioService = new UsuarioService();
            //    usuarioService.salvarUsuario(usuario);

            //    Cachorro cachorro = new Cachorro();
            //    Baleia baleia = new Baleia();
            //    Bicho bicho = cachorro;
            //    bicho.respirar();
            //    bicho = baleia;
            //    bicho.respirar();

            //    BichosAquaticos bichosAquaticos = baleia;
            //    BichosTerrestres bichosTerrestres = cachorro;
            //    bichosAquaticos.nadar();
            //    bichosTerrestres.caminhar();

            //    IPhone13 phone13 = new IPhone13();
            //    phone13.ligar();

            //    Nokia5120 nokia5120 = new Nokia5120();
            //    nokia5120.receberMensagem();

            //    Celular celular = phone13;
            //    celular.enviarMensagem();

            //    celular = nokia5120;
            //    celular.ligar();

            //    ProcessaArmazenamento processaArmazenamento = null;

            //    while (true)
            //    {
            //        Console.WriteLine("seleciona opcao para persistir a passagem\n" +
            //            "1. banco de dados\n" +
            //            "2. api\n" +
            //            "3. local (disco rigido)");
            //        String valor = Console.ReadLine();

            //        if (valor.Equals("1"))
            //        {
            //            processaArmazenamento = 
            //                new ProcessaArmazenamento(new BancoDadosArmazenamentoImpl());
            //        }
            //        else if (valor.Equals("2"))
            //        {
            //            processaArmazenamento =
            //                new ProcessaArmazenamento(new ApiArmazenamentoImpl());
            //        }
            //        else if (valor.Equals("3"))
            //        {
            //            processaArmazenamento =
            //                new ProcessaArmazenamento(new LocalArmazenamentoImpl());
            //        }
            //        else
            //        {
            //            break;
            //        }


            //        processaArmazenamento.executarPersitencia(new Passagem());


            //    }

            //}

            //public static ValidacaoOK validar(PinPad pinPad)
            //{
            //    // faz alguma coisa
            //    return new ValidacaoOK();
            //}

            //public static SalvarOK salvar(PinPad pinPad, ValidacaoOK validacaoOK)
            //{
            //    // faz alguma coisa
            //    return new SalvarOK();
            //}

            //public static void logSAlvarPinPad(PinPad pinPad, SalvarOK salvarOK)
            //{
            //    // faz alguma coisa
            //}



            ////static Optional<PinPad> buscar2(int id)
            ////{
            ////    PinPad pinPad = null; // faz a busca do pinpad
            ////    return new Optional<PinPad>(pinPad);
            ////}

            //static public PinPad buscar(int id)
            //{
            //    PinPad pinPad = null; // faz a busca do pinpad
            //    if (pinPad == null)
            //    {
            //        pinPad = new PinPadNaoEncontrado();
            //    }
            //    return pinPad;
            //}


            Director director = new Director();
            Builder b1 = new PizzaDoceBuilder1();
            Builder b2 = new PizzaQuatroQueijos();
            // Construct two products
            director.Construct(b1);
            Pizza p1 = b1.GetResult();
            p1.Show();
            director.Construct(b2);
            Pizza p2 = b2.GetResult();
            p2.Show();
            // Wait for user
            Console.ReadKey();
        }

    }
}
