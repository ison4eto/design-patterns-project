using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bevarage
{
    public abstract class ColdBeverage : Beverage
    {
        public abstract double cost();
        public abstract string getDescription();

        //template method
        public void prepareBeverage()
        {
            uncoverBeverage();
            pourInGlass();
            putPipet();

            if (customerWantsIce())
            {
                addIce();
            }
        }

        public void uncoverBeverage()
        {
            Console.WriteLine("Uncovering the bottle of drink");
        }

        public void pourInGlass()
        {
            Console.WriteLine("Pouring into glass");
        }

        public void putPipet()
        {
            Console.WriteLine("Put pipet in glass");
        }

        public void addIce()
        {
            Console.WriteLine("Adding ice");
        }

        //hook
        public bool customerWantsIce()
        {
            string answer = getUserInput();

            if (answer.ToLower().StartsWith("y"))
            {
                return true;
            }
            else
                return false;
        }

        private string getUserInput()
        {
            Console.Write("Would you like ice? (y/N)");
            string answer = Console.ReadLine();

            if (answer == null)
            {
                answer = "no";
            }

            return answer;
        }
    }
}
