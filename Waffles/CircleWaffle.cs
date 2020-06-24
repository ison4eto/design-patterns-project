using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Waffles
{
    class CircleWaffle: Waffle
    {
        public CircleWaffle()
        {
            description = "Circle Waffle";
        }
        public override double cost()
        {
            return 4.00;
        }
    }
}
