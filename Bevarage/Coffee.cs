using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bevarage
{
    public class Coffee : HotBeverage
    {
        double coffeeCost = 5.5;

        public override double cost()
        {
            return coffeeCost;
        }


        public override String getDescription()
        {
            return "Coffee";
        }


        public override void brew()
        {
            Console.WriteLine("Dripping coffee through filter");
        }


        public override void addCondiment()
        {
            Console.WriteLine("Adding milk");
        }

        //hook
        public bool customerWantsCondiment()
        {
            String answer = getUserInput();

            if (answer.ToLower().StartsWith("y"))
            {
                coffeeCost = coffeeCost + 1.5;
                return true;
            }
            else
                return false;
        }

        private String getUserInput()
        {
            Console.WriteLine("Would you like milk? --- 1.5$ (y/N)");
            String answer = Console.ReadLine();


            if (answer == null)
            {
                answer = "no";
            }

            return answer;
        }
    }
}
