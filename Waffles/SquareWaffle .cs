using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Waffles
{
    class SquareWaffle: Waffle
    {
        public SquareWaffle()
        {
            description = "Square Waffle";
        }

        public override double cost()
        {
            return 5.00;
        }
    }
}
