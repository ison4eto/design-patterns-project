using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Waffles.WaffleDecorator
{
    public class Coconut : CondimentDecorator
    {
        Waffle waffle;

        public Coconut(Waffle waffle)
        {
            this.waffle = waffle;
        }


        public override double cost()
        {
            return 0.10 + waffle.cost();
        }


        public override String getDescription()
        {
            return waffle.getDescription() + ", Coconut";
        }
    }
}
