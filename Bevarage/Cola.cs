using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bevarage
{
    public class Cola : ColdBeverage
    {

        public override double cost()
        {
            return 4.0;
        }

        public override String getDescription()
        {
            return "Coca Cola";
        }
    }
}
