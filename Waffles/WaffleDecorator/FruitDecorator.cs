using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Waffles.WaffleDecorator
{
    public abstract class FruitDecorator : Waffle
    {
        public abstract string getDescription();
    }
}
