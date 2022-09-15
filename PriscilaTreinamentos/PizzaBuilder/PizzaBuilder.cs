using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBuilder
{
    public class PizzaBuilder
    {
        private Pizza pizza;

        public PizzaBuilder()
        {
            pizza = new Pizza();
        }

       public PizzaBuilder comQueijo()
        {
            pizza.queijo = true;
            return this;
        }
        public PizzaBuilder semQueijo()
        {
            pizza.queijo = false;
            return this;
        }

        public PizzaBuilder comMolho()
        {
            pizza.molho = true;
            return this;
        }

        public PizzaBuilder semMolho()
        {
            pizza.molho = false;
            return this;
        }

        public PizzaBuilder comBacon()
        {
            pizza.bacon = true;
            return this;
        }

        public PizzaBuilder semBacon()
        {
            pizza.bacon = false;
            return this;
        }

        public PizzaBuilder comOvo()
        {
            pizza.ovo = true;
            return this;
        }

        public PizzaBuilder semOvo()
        {
            pizza.ovo = false;
            return this;
        }


        public PizzaBuilder comMilho()
        {
            pizza.milho = true;
            return this;
        }
        public PizzaBuilder semMilho()
        {
            pizza.milho = false;
            return this;
        }

        public Pizza fazerPizza()
        {
            return pizza;
        }
    }
}
