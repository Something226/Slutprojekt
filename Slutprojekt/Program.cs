using System;
using System.Collections.Generic;

namespace Slutprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables and lists/arrays 
            int PlayerGold = 15;

            string[] shopItemstrings = { "dagger", "potion", "sword", "armor" };
            int[] shopItemcost = { 5, 3, 10, 5 };

            List<string> playerItems = new List<string>();

            //inital message
            System.Console.WriteLine("Welcome to the shop\nWe have these items:"); 

            //for-loop that prints available items
            Printshopitems(shopItemstrings, shopItemcost);

            //requests player input
            System.Console.WriteLine("You have " + PlayerGold + " Gold, what would you like to buy?");

            //method for buying items
            BuyItem(shopItemstrings, shopItemcost, playerItems);

            Console.ReadLine();

        }
        //Buyitem method, used to remove and add items purchased by user
        static void BuyItem(string[] shopItemstrings, int[] shopItemcost, List<string> playerItems)
        {        
            //player input prompt
            System.Console.WriteLine("(Enter name of the item you want)");

            string item = Console.ReadLine();
            item = item.ToLower();

            //for-loop, checks for item name
            for (int i = 0; i < shopItemstrings.Length; i++)
            {
                if (item == shopItemstrings[i])
                {
                    System.Console.WriteLine("Are you sure you want that?(Y/n)");

                    string answer = "";

                    while (answer != "y" && answer != "n")
                    {
                        answer = Console.ReadLine().ToLower();

                        if (answer != "y" && answer != "n")
                        {
                            System.Console.WriteLine("Enter a valid answer");
                        }

                    }

                    if(answer == "y")
                    {
                        System.Console.WriteLine("cool");
                    }

                    if(answer == "n")
                    {
                        System.Console.WriteLine("cool");
                    }

                }

            }
        }

        //For-loop method, prints arrays
        static void Printshopitems(string[] shopItemstrings, int[] shopItemcost)
        {
            for (int i = 0; i < shopItemstrings.Length; i++)
            {
                if (shopItemcost[i] != -1)
                {
                    System.Console.WriteLine(shopItemstrings[i] + " = " + shopItemcost[i] + " Gold");
                }
            }

        }

    }

}
