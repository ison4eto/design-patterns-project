using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Waffles.WaffleDecorator
{
    class Almond : CondimentDecorator
    {
        Waffle waffle;

        public Almond(Waffle waffle)
        {
            this.waffle = waffle;
        }

        public override double cost()
        {
            return 0.35 + waffle.cost();
        }

        public override string getDescription()
        {
            return waffle.getDescription() + ", Almond";
        }
    }
}
