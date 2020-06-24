using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Waffles.WaffleDecorator
{
    public class Strawberry : FruitDecorator
    {
        Waffle waffle;

        public Strawberry(Waffle waffle)
        {
            this.waffle = waffle;
        }


        public override double cost()
        {
            return 0.60 + waffle.cost();
        }


        public override String getDescription()
        {
            return waffle.getDescription() + ", Strawberry";
        }
    }
}
