using System;

namespace PizzaBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizzaSemBuilder = new Pizza();
            pizzaSemBuilder.milho = true;
            pizzaSemBuilder.molho = true;
            pizzaSemBuilder.queijo = true;
            pizzaSemBuilder.bacon = true;
            pizzaSemBuilder.ovo = true;

            Pizza pizzaComBuilder = new PizzaBuilder()
                .comMolho()
                .comQueijo()
                .comBacon()
                .comMilho()
                .comOvo()
                .fazerPizza();
        }
    }
}
