using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Waffles.WaffleDecorator
{
    public class IceCream : CondimentDecorator
    {
        Waffle waffle;

        public IceCream(Waffle waffle)
        {
            this.waffle = waffle;
        }


        public override double cost()
        {
            return 2.5 + waffle.cost();
        }


        public override String getDescription()
        {
            return waffle.getDescription() + ", Ice Cream";
        }
    }
}

