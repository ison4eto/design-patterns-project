using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Waitress waitress = new Waitress();
            Cook cook = new Cook();

            while (true)
            {
                String beverageType = "";
                Console.WriteLine("What do you want to order?");
                Console.WriteLine("(1) Waffle");
                Console.WriteLine("(2) Drink");
                Console.WriteLine("(Other) I have finished ordering.");

                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    var chocoList = new List<string>();
                    var fruitList = new List<string>();
                    var condimentList = new List<string>();

                    String waffleType = null;
                    String answer = null;

                    while (true)
                    {
                        Console.WriteLine("Which waffle do you want?");
                        Console.WriteLine("(1) Square Waffle --- 5.0$");
                        Console.WriteLine("(2) Circular Waffle --- 4.0$");

                        answer = Console.ReadLine();

                        if (answer == "1")
                        {
                            waffleType = "Square Waffle";
                            Console.WriteLine("*** Square Waffle is chosen.");
                            break;
                        }
                        else if (answer == "2")
                        {
                            waffleType = "Circle Waffle";
                            Console.WriteLine("*** Circular Waffle is chosen.");
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    Console.WriteLine("");

                    Console.WriteLine("-------------------- INGREDIENTS --------------------");
                    for (int i = 0; i < 2; i++)
                    {
                        Console.WriteLine("-------------------- Chocolate Types --------------------");
                        Console.WriteLine("(1) White Chocolate --- 1.5$");
                        Console.WriteLine("(2) Nutella --- 1.25$");
                        Console.WriteLine("(Other) I finished the chocolate selection.");

                        int value = Convert.ToInt32(Console.ReadLine());
                        if (value == 1)
                        {
                            chocoList.Add("White");
                            Console.WriteLine("*** White Chocolate is chosen.");
                        }
                        else if (value == 2)
                        {
                            chocoList.Add("Normal");
                            Console.WriteLine("*** Nutella is chosen.");
                        }
                        else break;
                    }
                    Console.WriteLine("The selection of chocolates is completed.");
                    Console.WriteLine("");

                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("-------------------- Fruit Types --------------------");
                        Console.WriteLine("(1) Banana --- 0.75$");
                        Console.WriteLine("(2) Strawberry --- 0.65$");
                        Console.WriteLine("(3) Kiwi --- 0.85$");
                        Console.WriteLine("(Other) I finished the fruit selection.");
                        int value = Convert.ToInt32(Console.ReadLine());
                        if (value == 1)
                        {
                            fruitList.Add("Banana");
                            Console.WriteLine("*** Banana is chosen.");
                        }
                        else if (value == 2)
                        {
                            fruitList.Add("Strawberry");
                            Console.WriteLine("*** Strawberry is chosen.");
                        }
                        else if (value == 3)
                        {
                            fruitList.Add("Kiwi");
                            Console.WriteLine("*** Kiwi is chosen.");
                        }
                        else break;
                    }
                    Console.WriteLine("The selection of fruits is completed.");
                    Console.WriteLine("");

                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("-------------------- Condiment Types --------------------");
                        Console.WriteLine("(1) Ice Cream --- 2.5$");
                        Console.WriteLine("(2) Coconut --- 0.1$");
                        Console.WriteLine("(3) Almond --- 0.35$");
                        Console.WriteLine("(Other) I finished the condiment selection.");
                        int value = Convert.ToInt32(Console.ReadLine());
                        if (value == 1)
                        {
                            condimentList.Add("Ice Cream");
                            Console.WriteLine("*** Ice Cream is chosen.");
                        }
                        else if (value == 2)
                        {
                            fruitList.Add("Coconut");
                            Console.WriteLine("*** Coconut is chosen.");
                        }
                        else if (value == 3)
                        {
                            fruitList.Add("Almond");
                            Console.WriteLine("*** Almond is chosen.");
                        }
                        else break;
                    }
                    Console.WriteLine("The selection of condiments is completed.");
                    Console.WriteLine("");

                    String[] chocoArr = new String[chocoList.Count];
                    chocoArr = chocoList.ToArray();

                    String[] fruitArr = new String[fruitList.Count];
                    fruitArr = fruitList.ToArray();

                    String[] condimentArr = new String[condimentList.Count];
                    condimentArr = condimentList.ToArray();

                    WaffleOrder waffleOrder = new WaffleOrder(cook, waffleType, chocoArr, fruitArr, condimentArr);
                    waitress.takeOrder(waffleOrder);
                }

                else if (a == 2)
                {
                    Console.WriteLine("-------------------- DRINKS --------------------");
                    for (int i = 0; i < 1; i++)
                    {
                        Console.WriteLine("-------------------- Drink Types --------------------");
                        Console.WriteLine("(1) Tea --- 2.5$");
                        Console.WriteLine("(2) Coffee --- 5.5$");
                        Console.WriteLine("(3) Cola --- 4.0$");
                        Console.WriteLine("(4) Ice Tea --- 4.5$");
                        Console.WriteLine("(5) Fanta --- 4.0$");
                        Console.WriteLine("(Other) I finished the drink selection.");
                        int drink = Convert.ToInt32(Console.ReadLine());
                        if (drink == 1)
                        {
                            beverageType = "Tea";
                            Console.WriteLine("*** Tea is chosen.");
                        }
                        else if (drink == 2)
                        {
                            beverageType = "Coffee";
                            Console.WriteLine("*** Coffee is chosen.");
                        }
                        else if (drink == 3)
                        {
                            beverageType = "Cola";
                            Console.WriteLine("*** Cola is chosen.");
                        }
                        else if (drink == 4)
                        {
                            beverageType = "Ice Tea";
                            Console.WriteLine("*** Ice Tea is chosen.");
                        }
                        else if (drink == 5)
                        {
                            beverageType = "Fanta";
                            Console.WriteLine("*** Fanta is chosen.");
                        }
                        else
                        {
                            break;
                        }
                    }
                    Console.WriteLine("The selection of drinks is completed.");
                    Console.WriteLine("");

                    BeverageOrder beverageOrder = new BeverageOrder(cook, beverageType);
                    waitress.takeOrder(beverageOrder);
                }

                else
                {
                    Console.WriteLine("-------------------------------------------------------------------------------");
                    Console.WriteLine("BON APPETIT");
                    break;
                }
            }
        }
    }
}
