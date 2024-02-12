using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] foods =
            [
                "Coca Cola 150 ml",
                "Chicken Salad",
                "Pizza Margherita",
                "Four Cheeses Pizza",
                "French Fries",
                "Rice Salad",
                "Seasonal Fruit",
                "Fried Pizza",
                "Vegetarian Piadina",
                "Hamburger Sandwich"
            ];

            double[] prices =
            [
                2.50,
                5.20,
                10.00,
                12.50,
                3.50,
                8.00,
                5.00,
                5.00,
                6.00,
                7.90
            ];

            List<int> choices = [];
            double totalCost = 0.0;

            while (true)
            {
                Console.WriteLine(" ***** MENU *****");
                for (int i = 0; i < foods.Length; i++)
                {
                    Console.WriteLine($"{i + 1}: {foods[i]} (€ {prices[i]})");
                }
                Console.WriteLine("Type 'ok' to print the final bill and confirm");
                Console.WriteLine("Select an option or type 'ok':");

                var input = Console.ReadLine().Trim().ToLower();
                if (input == "ok")
                {
                    break;
                }
                else if (int.TryParse(input, out int choice) && choice >= 1 && choice <= foods.Length)
                {
                    choice -= 1;
                    choices.Add(choice);
                    totalCost += prices[choice];
                    Console.WriteLine($"You've added: {foods[choice]}");
                }
                else
                {
                    Console.WriteLine("Invalid choice, please try again.");
                }
            }

            Console.WriteLine(" ***** Your Order ***** ");
            foreach (int index in choices)
            {
                Console.WriteLine($"{foods[index]} - €{prices[index]}");
            }
            totalCost += 3.00;
            Console.WriteLine("Service charge: €3.00");
            Console.WriteLine($"Total cost: €{totalCost:F2}");
        }
    }
}