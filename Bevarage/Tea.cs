using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bevarage
{
    public class Tea : HotBeverage
    {
        double teaCost = 2.5;


        public override double cost()
        {
            return teaCost;
        }


        public override String getDescription()
        {
            return "Tea";
        }


        public override void brew()
        {
            Console.WriteLine("Steeping the tea");
        }


        public override void addCondiment()
        {
            Console.WriteLine("Adding lemon");
        }

        //hook
        public bool customerWantsCondiment()
        {
            String answer = getUserInput();

            if (answer.ToLower().StartsWith("y"))
            {
                teaCost = teaCost + 0.5;
                return true;
            }
            else
                return false;
        }

        private String getUserInput()
        {
            Console.WriteLine("Would you like lemon? --- 0.5$ (y/N)");
            String answer = Console.ReadLine();

            if (answer == null)
            {
                answer = "no";
            }

            return answer;
        }
    }
}
