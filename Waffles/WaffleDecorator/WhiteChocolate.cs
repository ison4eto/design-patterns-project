using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Waffles.WaffleDecorator
{
    public class WhiteChocolate : ChocolateDecorator
    {
        Waffle waffle;

        public WhiteChocolate(Waffle waffle)
        {
            this.waffle = waffle;
        }


        public override double cost()
        {
            return 1.50 + waffle.cost();
        }


        public override String getDescription()
        {
            return waffle.getDescription() + ", White Chocolate";
        }
    }
}
