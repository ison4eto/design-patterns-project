using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Waffles.WaffleDecorator
{
    public abstract class ChocolateDecorator : Waffle
    {
        public abstract String getDescription();
    }
}
