using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Project_fr
{
    class Store
    {
        public double wallet;
        public double icecubescost;
        public double sugarcost;
        public double lemonscost;
        public double cupcost;
        public string displaystore;
        public Player Player;

        public Store(Player Player)
        {
            icecubescost = 0.10;
            sugarcost = 0.15;
            lemonscost = 0.20;
            cupcost = 0.05;
            this.Player = Player;
            wallet = Player.inventory.wallet;
        }
      


        public double IceCubesCost()
        {
            Console.WriteLine("Ice cubes cost $0.10. How many ice cubes would you like to buy?");
            double IceCubesCost = double.Parse(Console.ReadLine());
            return IceCubesCost;
        }

        public double SugarCost()
        {
            Console.WriteLine("Sugar cost $0.15. How many cups of sugar would you like to buy?");
            double SugarCost = double.Parse(Console.ReadLine());
            return SugarCost;
        }

        public double LemonCost()
        {
            Console.WriteLine("Lemons cost $0.20. How many lemons per pitcher would you like to buy?");
            double LemonsCost = double.Parse(Console.ReadLine());
            return LemonsCost;
        }
        public double CupsCost()
        {
            Console.WriteLine("Cups cost $0.5. How many cups would you like to buy?");
            double CupsCost = double.Parse(Console.ReadLine());
            return CupsCost;
        }

        public void DisplayStore(Player player)
        {
            Console.WriteLine("What would you like to shop for? [Lemons] [Ice cubes] [Sugar] [Cups] [Done] You have " + player.inventory.wallet + " left to spend.");
            string userInput = Console.ReadLine();
            //make a new method to slim code
            switch (userInput)
            {
                case "Lemons":
                    double lemonsToBuy = LemonCost();
                    if(player.inventory.wallet >= lemonsToBuy * lemonscost)
                    {
                        player.inventory.IncreaseInventory("Lemons", lemonsToBuy, lemonscost);
                        // take there money
                       
                        DisplayStore(player);
                    }
                    break;
                case "Sugar":
                    double sugarToBuy = SugarCost();
                    if (player.inventory.wallet >= sugarToBuy * sugarcost)
                    {
                        player.inventory.IncreaseInventory("Sugar", sugarToBuy, sugarcost);
                        DisplayStore(player);
                    }
                    break;
                case "Ice cubes":
                    double iceCubesToBuy = IceCubesCost();
                    if (player.inventory.wallet >= iceCubesToBuy * icecubescost)
                    {
                        player.inventory.IncreaseInventory("Ice cubes", iceCubesToBuy, icecubescost);
                        DisplayStore(player);
                    }                   
                    break;
                case "Cups":
                    double cupsToBuy = CupsCost();
                    if (player.inventory.wallet >= cupsToBuy * cupcost)
                    {
                        player.inventory.IncreaseInventory("Cups", cupsToBuy, cupcost);
                        DisplayStore(player);
                    }
                    break;
                case "Done":
                    break;
                default:
                    Console.WriteLine("Please enter a coresponding choice (8^()");
                    Console.ReadLine();
                    DisplayStore(player);
                    break;
            }
            

        }
    }
}
            
     

