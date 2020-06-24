using DesignPatterns.Waffles;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class WaffleFactory
    {

        public Waffle makeWaffle(String waffleType)
        {
            if (waffleType == null)
            {
                return null;
            }
            else if (waffleType == "Square Waffle")
            {
                return new SquareWaffle();
            }
            else if (waffleType == "Circle Waffle")
            {
                return new CircleWaffle();
            }
            return null;
        }

    }
}
