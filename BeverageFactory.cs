using DesignPatterns.Bevarage;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class BeverageFactory
    {

        public Beverage makeBeverage(String beverageType)
        {
            switch (beverageType)
            {
                case "Tea":
                    return new Tea();
                case "Coffee":
                    return new Coffee();
                case "Cola":
                    return new Cola();
                case "Fanta":
                    return new Fanta();
                case "Ice Tea":
                    return new IceTea();
                default:
                    return null;
            }
        } 

    }
}
