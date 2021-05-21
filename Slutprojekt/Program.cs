using System;
using System.Collections.Generic;

namespace Slutprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables and lists/arrays 

            List<string> shopItemstrings = new List<string>() { "dagger", "potion", "sword", "armor" };
            // List<int> shopItemcost = new List<int>() { 5, 3, 10, 5 };

            List<string> playerItems = new List<string>();

            //inital message
            System.Console.WriteLine("Welcome to the shop\nWe have these items:");

            //for-loop that prints available items
            Printitems(shopItemstrings);

            //requests player input
            System.Console.WriteLine("What would you like to buy?");

            //method for buying items
            BuyItem(shopItemstrings, playerItems);

            Printitems(shopItemstrings);

            //list that shows player items
            System.Console.WriteLine("Player has these items");
            Printitems(playerItems);

            Console.ReadLine();

        }
        //Buyitem method, used to remove and add items purchased by user
        static void BuyItem(List<string> shopItemstrings, List<string> playerItems)
        {
            //player input prompt
            System.Console.WriteLine("(Enter name of the item you want)");

            string item = Console.ReadLine();
            item = item.ToLower();

            //for-loop, checks for item name
            for (int i = 0; i < shopItemstrings.Count; i++)
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

                    if (answer == "y")
                    {

                        shopItemstrings.Remove(item);

                        playerItems.Add(item);

                    }

                    if (answer == "n")
                    {
                        System.Console.WriteLine("cool");
                    }

                }

            }
        }

        //For-loop method, prints lists
        static void Printitems(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                System.Console.WriteLine(list[i]);

            }

        }

    }

}
