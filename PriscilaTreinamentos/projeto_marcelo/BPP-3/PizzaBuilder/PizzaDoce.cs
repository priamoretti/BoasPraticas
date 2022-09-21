using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_3.PizzaBuilder
{
    class PizzaDoceBuilder1 : Builder
    {
        private Pizza _product = new Pizza();
        public override void BuildBorda()
        {
            _product.Add("Borda de chocolate");
        }

        public override void BuildRecheio()
        {
            _product.Add("Recheio doce de chocolate com morango");
        }


        public override Pizza GetResult()
        {
            return _product;
        }
    }
}
