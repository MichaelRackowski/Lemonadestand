using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Project_fr
{
    class store
    {
        public double wallet;
        public double icecubescost;
        public double sugarcost;
        public double lemonscost;
        public double cupcost;
        public string displaystore;
        public player Player;

        public store(player Player)
        {
            icecubescost = 0.10;
            sugarcost = 0.15;
            lemonscost = 0.20;
            cupcost = 0.05;
            this.Player = Player;

        }
        public double Wallet()
        {
            Console.WriteLine($"You have ${wallet} left");
            double Wallet = double.Parse(Console.ReadLine());
            return wallet;
        }


        public double IceCubesCost()
        {
            Console.WriteLine("Ice cubes cost $0.10. How many ice cubes would you like to buy?");
            double IceCubesCost = double.Parse(Console.ReadLine());
            return icecubescost;
        }

        public double SugarCost()
        {
            Console.WriteLine("Sugar cost $0.15. How many cups of sugar would you like to buy?");
            double SugarCost = double.Parse(Console.ReadLine());
            return sugarcost;
        }

        public double LemonCost()
        {
            Console.WriteLine("Lemons cost $0.20. How many lemons per pitcher would you like to buy?");
            double LemonsCost = double.Parse(Console.ReadLine());
            return lemonscost;
        }
        public double CupsCost()
        {
            Console.WriteLine("Cups cost $0.05. How many cups would you like to buy?");
            double CupsCost = double.Parse(Console.ReadLine());
            return cupcost;
        }

        public void DisplayStore(player player)
        {
            Console.WriteLine("What would you like to shop for? [Lemons] [Ice cubes] [Sugar] [Cups]");
            string userInput = Console.ReadLine();
            //make a new method to slim code
            switch (userInput)
            {
                case "Lemons":
                    double lemonsToBuy = LemonCost();
                    if(player.inventory.Wallet >= lemonsToBuy * lemonscost)
                    {
                        player.inventory.IncreaseInventory("Lemons", lemonsToBuy, lemonscost);
                    }
                    break;
                case "Sugar":
                    double sugarToBuy = SugarCost();
                    if (player.inventory.Wallet >= sugarToBuy * sugarcost)
                    {
                        player.inventory.IncreaseInventory("Sugar", sugarToBuy, sugarcost);
                    }                   
                    break;
                case "Ice cubes":
                    double iceCubesToBuy = IceCubesCost();
                    if (player.inventory.Wallet >= iceCubesToBuy * icecubescost)
                    {
                        player.inventory.IncreaseInventory("Ice cubes", iceCubesToBuy, icecubescost);
                    }                   
                    break;
                case "Cups":
                    double cupsToBuy = CupsCost();
                    if (player.inventory.Wallet >= cupsToBuy * cupcost)
                    {
                        player.inventory.IncreaseInventory("Cups", cupsToBuy, cupcost);
                    }
                    break;
                default:
                    Console.WriteLine("Please enter a coresponding choice (8^()");
                    Console.ReadLine().ToLower();
                    break;
            }
            

        }
    }
}
            
     

