using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_3.PizzaBuilder
{
    class Director
    {
        // Builder uses a complex series of steps
        public void Construct(Builder builder)
        {
            builder.BuildBorda();
            builder.BuildRecheio();
         
        }
    }
}
