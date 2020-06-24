using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Waffles.WaffleDecorator
{
    public class MilkChocolate : ChocolateDecorator
    {
        Waffle waffle;

        public MilkChocolate(Waffle waffle)
        {
            this.waffle = waffle;
        }


        public override double cost()
        {
            return 1.25 + waffle.cost();
        }


        public override String getDescription()
        {
            return waffle.getDescription() + ", Chocolate";
        }
    }
}
