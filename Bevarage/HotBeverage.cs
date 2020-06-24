using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bevarage
{
    public abstract class HotBeverage : Beverage
    {
        public abstract double cost();
        public abstract String getDescription();

        //template method
        public void prepareBeverage()
        {
            boilWater();
            brew();
            pourInCup();

            if (customerWantsCondiment())
            {
                addCondiment();
            }
        }

        public void boilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public abstract void brew();

        public void pourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        public abstract void addCondiment();

        bool customerWantsCondiment()
        {
            return true;
        }
    }
}
