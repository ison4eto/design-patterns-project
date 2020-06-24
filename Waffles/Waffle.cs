using System;
using System.Collections.Generic;
using System.Text;

// Component
namespace DesignPatterns.Waffles
{
    public abstract class Waffle
    {
        protected string description;

        public abstract double cost();
        public string getDescription()
        {
            return description;
        }

        public void prepareDough(string type)
        {
            Console.WriteLine("Preparing " + type + " dough");
        }

        public void cookDough(string type)
        {
            Console.WriteLine("Cooking " + type + " dough");
        }

        public void dishUp(string type)
        {
            Console.WriteLine("Put " + type + " on the dish");
        }
    }
}
