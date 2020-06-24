using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bevarage
{
    public interface Beverage
    {
        public String getDescription();
        public double cost();
        public void prepareBeverage();
    }
}
