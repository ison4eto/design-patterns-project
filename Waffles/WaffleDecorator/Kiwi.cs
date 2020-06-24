using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Waffles.WaffleDecorator
{
    public class Kiwi : FruitDecorator
    {
        Waffle waffle;

        public Kiwi(Waffle waffle)
        {
            this.waffle = waffle;
        }


        public override double cost()
        {
            return 0.85 + waffle.cost();
        }


        public override String getDescription()
        {
            return waffle.getDescription() + ", Kiwi";
        }
    }
}
