﻿using System;
using SupermarketCheckout.Logic;

namespace SupermarketCheckout
{
    internal static class Program
    {        
        /// <summary>
        /// Show menu
        /// </summary>
        private static void Main()
        {
            var showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        /// <summary>
        /// Write menu and get user input
        /// </summary>
        /// <returns>Boolean</returns>
        private static Boolean MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Scan a product:");
            Console.WriteLine("1) Apple");
            Console.WriteLine("2) Banana");
            Console.WriteLine("3) Peach");
            Console.WriteLine("\u001b[32mC) Go to checkout\u001b[0m");
            Console.WriteLine("\u001b[33mX) Break and exit\u001b[0m");
            Console.Write("\r\nSelect an option: ");

            var userInput = Console.ReadLine().ToUpper();


            switch (userInput)
            {
                case "C":
                    ShoppingCart.ShowTotal();
                    break;
                case "X":
                    return false;
                default:
                    ShoppingCart.Scan(userInput);
                    break;
            }

            return true;
        }
    }
}
