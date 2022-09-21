using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_3.PizzaBuilder
{
    class PizzaQuatroQueijos : Builder
    {
        private Pizza _product = new Pizza();
        public override void BuildBorda()
        {
            _product.Add("Sem Borda");
        }

        public override void BuildRecheio()
        {
            _product.Add("Recheio de quatro queijos");
        }

     

        public override Pizza GetResult()
        {
            return _product;
        }
    }
}
