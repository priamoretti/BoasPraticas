using System;
using System.Collections.Generic;
using System.Text;

namespace BPP_3.PizzaBuilder
{
    abstract class Builder
    {
        public abstract void BuildBorda();
        public abstract void BuildRecheio();
       
        public abstract Pizza GetResult();
    }
}
