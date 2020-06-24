using DesignPatterns.Bevarage;
using DesignPatterns.Waffles;
using DesignPatterns.Waffles.WaffleDecorator;
using System;

namespace DesignPatterns
{
    public class Cook
    {
        public String waffleType { get; set; }
        public String beverageType { get; set; }
        public String[] chocoList { get; set; }
        public String[] fruitList { get; set; }
        public String[] condimentList { get; set; }
        Waffle waffle;
        Beverage beverage;
        public void getOrder(String factoryType)
        {
            if (factoryType.ToLower() == "waffle")
            {
                Console.WriteLine(waffleType + " order received.");

                WaffleFactory factory = new WaffleFactory();
                waffle = factory.makeWaffle(waffleType);

                waffle.prepareDough(waffleType);
                waffle.cookDough(waffleType);
                waffle.dishUp(waffleType);
                waffle = decorate(chocoList, fruitList, condimentList);

                Console.WriteLine(waffle.getDescription() + " order completed.");
                Console.WriteLine("Cost: $" + waffle.cost());

            }
            else if (factoryType.ToLower() == "beverage")
            {
                Console.WriteLine(beverageType + " order received.");

                BeverageFactory factory = new BeverageFactory();
                beverage = factory.makeBeverage(beverageType);
                beverage.prepareBeverage();

                Console.WriteLine(beverage.getDescription() + " order completed.");
                Console.WriteLine("Cost: $" + beverage.cost());
            }
            Console.WriteLine("");
        }

        public Waffle decorate(String[] chocoList, String[] fruitList, String[] condimentList)
        {
            for (int i = 0; i < chocoList.Length; i++)
            {
                String choco = chocoList[i];
                if (choco == "White")
                {
                    waffle = new WhiteChocolate(waffle);
                }
                else if (choco == "Normal")
                {
                    waffle = new MilkChocolate(waffle);
                }
            }

            for (int i = 0; i < fruitList.Length; i++)
            {
                String fruit = fruitList[i];
                if (fruit == "Banana")
                {
                    waffle = new Banana(waffle);
                }
                else if (fruit == "Strawberry")
                {
                    waffle = new Strawberry(waffle);
                }
                else if (fruit == "Kiwi")
                {
                    waffle = new Kiwi(waffle);
                }
            }

            for (int i = 0; i < condimentList.Length; i++)
            {
                String condiment = condimentList[i];
                if (condiment == "Almond")
                {
                    waffle = new Almond(waffle);
                }
                else if (condiment == "Coconut")
                {
                    waffle = new Coconut(waffle);
                }
                else if (condiment == "Ice Cream")
                {
                    waffle = new IceCream(waffle);
                }
            }
            return waffle;
        }
    }
}