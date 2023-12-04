using System;

namespace OnlineShoppingMall
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("=====Welcome to the Mall!=====\nHere are the available items in the store");
            Console.WriteLine("1. Wrist Watches\n2. Sneakers\n3. Shirts\nWhat would You like to buy?\nEnter '1' to buy Wrist watch, '2' to buy Sneakers and '3' to buy Shirts.");
        
            var userInput = Console.ReadLine()!;

            // List created for Wist watches
            List<WristWatches> wristWatches = new List<WristWatches>
            {
                new WristWatches {ItemName = "Rolex", Price = 400, Type = "Fashion Watch"},
                new WristWatches {ItemName = "Quartz", Price = 2800, Type = "Divers Watch"},
                new WristWatches {ItemName = "G-Shock", Price = 340, Type = "Fashion Watch"}
            };
    
            // List created for Sneakers
            List<Sneakers> sneakers = new List<Sneakers>
            {
                new Sneakers {ItemName = "Air Nike", Price = 1400, Size = "44"},
                new Sneakers {ItemName = "Puma", Price = 1000, Size = "45"},
                new Sneakers {ItemName = "Adidas", Price = 1140, Size = "40 "},
                new Sneakers {ItemName = "Air Nike", Price = 1400, Size = "43"},
                new Sneakers {ItemName = "Puma", Price = 1000, Size = "44"},
                new Sneakers {ItemName = "Adidas", Price = 1140, Size = "41 "},
                new Sneakers {ItemName = "Air Nike", Price = 1400, Size = "40"},
                new Sneakers {ItemName = "Puma", Price = 1000, Size = "42"},
                new Sneakers {ItemName = "Adidas", Price = 1140, Size = "44 "},
            };
            
            // List created for Shirts
            List<Shirts> shirts = new List<Shirts>
            {
                new Shirts {ItemName = "Hood", Price = 400, Maker = "Louis Vuiton "},
                new Shirts {ItemName = "Polo", Price = 2800, Maker = "Gucci"},
                new Shirts {ItemName = "Round Neck", Price = 340, Maker = "Versace"}
            };

            switch (userInput)
            {
                case "1":
                Console.WriteLine("");
                Console.WriteLine("Available Sneakers: ");
                foreach (var item in sneakers)
                {
                    Console.WriteLine($"{item.ItemName}, Size {item.Size} for ${item.Price}");
                }
                    break;
                case "2":
                Console.WriteLine("");
                Console.WriteLine("Available Wrist Watches : ");
                foreach (var item in wristWatches)
                {
                    Console.WriteLine($"{item.ItemName} {item.Type} for ${item.Price}");
                }
                    break;
                case "3":
                Console.WriteLine("\nAvailable  Shirts: ");
                foreach (var item in shirts)
                {
                    Console.WriteLine($"{item.Maker} {item.ItemName} for ${item.Price}");
                }
                    break;
                default:
                    break;
            }
            Console.WriteLine("Which item would you like to buy? ");
            var newUserInput = Console.ReadLine()!;
        }
    }
}