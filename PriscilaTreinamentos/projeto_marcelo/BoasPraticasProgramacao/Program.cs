using BoasPraticasProgramacao.BPP_3.aula8;
using BoasPraticasProgramacao.BPP_3.Builder;
using BoasPraticasProgramacao.BPP_3.Composite;
using BoasPraticasProgramacao.BPP_3.Composite.Nota;
using BoasPraticasProgramacao.Strategy;
using BoasPraticasProgramacao.Strategy.Exercicio;
using System;

namespace BoasPraticasProgramacao
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXERCICIO AULA 1
            //CalculadoraPag c = new CalculadoraPag("maria", 30, "26/06/1990", 500);
            //float ret = c.retornaCalculoFuncionario();
            //Console.WriteLine("salário: " + ret);

            // EXERCICIO AULA 2
            //Televisao tv1 = new Televisao("samsung", 42);
            //Cadastrar c = new Cadastrar();
            //c.adiciona(tv1);

            //Console.WriteLine(c.buscaTelevisao("cce"));

            // TESTE DO PRINCIPIO substituição de Liskov
            // Cachorro cachorro = new Cachorro();
            // Baleia baleia = new Baleia();
            // Bixo bixo = cachorro;
            // bixo.caminha();
            // bixo.nada();
            // bixo = baleia;
            // bixo.nada();
            // bixo.caminha();

            // TESTE DO PRINCIPIO inversao da dependencia.
            //BancoDadosImpl bancoDadosImpl = new BancoDadosImpl(new BancoDadosOracle());
            //bancoDadosImpl.salvando();
            //bancoDadosImpl.bancoDados = new BancoDadosSqlServer();
            //bancoDadosImpl.salvando();

            // TESTE PADRAO PROJETO FACTORY METHOD
            //FabricaVeiculos fabricaVeiculos = new FabricaVeiculos();
            //IVeiculo onibus = fabricaVeiculos.criaVeiculo("empresaA");
            //onibus.pagar();

            // TESTE PADRAO PROEJTO COMPOSITE
            //Internet internet = new Internet();
            //internet.realizaCompra(50);
            //internet.realizaCompra(30);
            //NaRua naRua = new NaRua();
            //naRua.realizandoCompra(10);
            //naRua.realizandoCompra(20);
            //Loja loja = new Loja();
            //loja.comprar(40);

            //TotalComprasComposite totalComprasComposite = new TotalComprasComposite();
            //totalComprasComposite.adicionaTotalCompras(internet);
            //totalComprasComposite.adicionaTotalCompras(naRua);
            //totalComprasComposite.adicionaTotalCompras(loja);
            //int totalComprasDia = totalComprasComposite.retornaTotalComprasDoDia();
            //Console.WriteLine("total de compras dia R$ " + totalComprasDia);

            //Pedido pedido = new Pedido();
            //FacadePedido facadePedido = new FacadePedido();
            //facadePedido.executarPedido(pedido);


            //Aplicativo app = new Aplicativo();
            //app.realizarCompras(50);
            //app.realizarCompras(90);

            //InternetPDV internet = new InternetPDV();
            //internet.realizarCompras(80);

            //LojaPDV loja = new LojaPDV();
            //loja.realizarCompras(15);
            //loja.realizarCompras(25);

            //NaRuaPDV narua = new NaRuaPDV();
            //narua.realizarCompras(25);
            //narua.realizarCompras(39);


            //Composite totaldoDia = new Composite();
            //totaldoDia.adicionarPontoDeVenda(app);
            //totaldoDia.adicionarPontoDeVenda(internet);
            //totaldoDia.adicionarPontoDeVenda(loja);
            //totaldoDia.adicionarPontoDeVenda(narua);

            //int total = totaldoDia.retornaTotalComprasDoDia();

            //Console.WriteLine("total de compras dia R$: " + total);


            //NotaDeItens nfitens = new NotaDeItens();

            //nfitens.InserirLinha("Número nota");
            //nfitens.InserirLinha("Valor");
            //nfitens.InserirLinha("Obs");


            //NotaDeServico nfservico = new NotaDeServico();
            //nfservico.InserirLinha("Número nota");
            //nfservico.InserirLinha("Item 1");
            //nfservico.InserirLinha("Item 2");
            //nfservico.InserirLinha("Item 3");
            //nfservico.InserirLinha("Obs");

            //CompositeNota compo = new CompositeNota();

            //compo.adicionarNotaFiscal(nfitens);
            //compo.adicionarNotaFiscal(nfservico);
            //compo.retornaNFPronta();


            //BPP_3.Builder.Nota nota1 = new NotaBuilder().
            //    notacomnumero()
            //    .notacomvalor()
            //    .notacomobseracao()
            //    .FazerNota();


            //BPP_3.Builder.Nota nota2 = new NotaBuilder().
            //notacomnumero()
            //.notacomitens()
            //.notacomdescricao()
            //.FazerNota();


            //ImpostoContexto impostocontexto = new ImpostoContexto();
            //Impostos impostos = impostocontexto.getStrategy("IPI");
            //double calculo1 = impostos.calcular(280);
            //double impostoscalculados = impostocontexto.calcular("IPI", 280);


            //Console.WriteLine("Imposto getstrategy = " + calculo1.ToString());
            //Console.WriteLine("Imposto calculado = " + impostoscalculados.ToString());



            MeiosDePagamentoContexto meiosDePagamentoContexto = new MeiosDePagamentoContexto();
            MeiosDePagamento meiodepagamento = meiosDePagamentoContexto.GetStrategy("PIX");
            double valor = meiodepagamento.Pagar(50);
            Console.WriteLine("Pagando em pix: " +  valor);


            meiosDePagamentoContexto.Pagar("Dinheiro", 50);

            






        }
    }
}
