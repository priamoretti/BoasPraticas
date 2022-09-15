
using PriscilaTreinamentos.Telefone;
using System;
using TreinamentoLiskov.Passagem;
using TreinamentoLiskov.Log;

namespace TreinamentoLiskov
{
    public class Program
    {
        static void Main(string[] args)
        {
            //IPlanoCelularInternet celular = new IPlanoCelularInternet();
            //celular.EntrarInternet();
            //celular.EnviarMensagem();

            Sistema sistema = new Sistema();
            sistema.bancodedados = new Oracle();
            sistema.Salvar(new Passagem1());

            //Calculadora calculadora = new Calculadora(new LogMessage());
            //calculadora.somar(1, 1);
            //calculadora.subtrair(3, 2);
            //calculadora.log = new LogConsole();
            //calculadora.somar(1,1);
            //calculadora.subtrair(3, 2);



        }
    }
}
