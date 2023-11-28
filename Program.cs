using System;

namespace OnlineShoppingMall
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome();
            PurchaseItem();
        }
        static void Welcome()
        {
            Console.WriteLine("=====Welcome to the Mall!=====\nHere are the available items in the store");
            Console.WriteLine("Sneakers\nWrist Watches\nShirts\nWhat would you like to buy?");
        }
        static void PurchaseItem()
        {
            var item = Console.ReadLine();
            switch (item)
            {
                case "Sneakers":
                var sneakers = new Sneakers();
                sneakers.Size = "43";
                sneakers.ItemName = "Air Nike";
                sneakers.Price = 120.98;
                Console.WriteLine($"You Purchased an {sneakers.ItemName} sneakers of size {sneakers.Size} for ${sneakers.Price}");
                    break;
                case "WristWatches":
                var wristWatches = new Wristwatches();
                wristWatches.Type = "Fashion Watch";
                wristWatches.ItemName = "Rolex";
                wristWatches.Price = 67.99;
                Console.WriteLine($"You Purchased a {wristWatches.ItemName}  {wristWatches.Type} for ${wristWatches.Price}");
                    break;
                case "Shirts":
                var shirts = new Shirts();
                shirts.Maker = "Louis Vuiton";
                shirts.ItemName = "Hood";
                shirts.Price = 400.25;
                Console.WriteLine($"You Purchased a {shirts.Maker} {shirts.ItemName} for ${shirts.Price}");
                    break;
                default:
                    break;
            }
        }
    }
}