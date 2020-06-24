using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Waffles.WaffleDecorator
{
    public class Banana : FruitDecorator
    {
        Waffle waffle;

        public Banana(Waffle waffle)
        {
            this.waffle = waffle;
        }

        public override double cost()
        {
            return 0.75 + waffle.cost();
        }


        public override String getDescription()
        {
            return waffle.getDescription() + ", Banana";
        }
    }
}
