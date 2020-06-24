using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class BeverageOrder : Command
    {
        Cook cook;
        string order;
        public BeverageOrder(Cook cook, string order)
        {
            this.cook = cook;
            this.order = order;
        }


        public void orderUp()
        {
            cook.beverageType = order;
            cook.getOrder("Beverage");
        }
    }
}
