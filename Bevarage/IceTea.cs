using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bevarage
{
    public class IceTea : ColdBeverage
    {

        public override double cost()
        {
            return 4.5;
        }


        public override String getDescription()
        {
            return "Lipton Ice Tea";
        }
    }
}
