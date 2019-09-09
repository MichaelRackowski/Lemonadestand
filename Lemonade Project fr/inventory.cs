using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Project_fr
{
    public class inventory
    {
        public int InventoryPurchasing; 
        public double IceCubes;
        public double Sugar;
        public double Cups;
        public double Lemons;
        public double wallet;
        public inventory()
        {

            wallet = 20.00;
        }

        public void RecipeSubtractor(Recipe Recipe)
        {
            if (Lemons >= Recipe.lemons)
            {
                Lemons -= Recipe.lemons;
            }
            if (Sugar >= Recipe.sugar)
            {
                Sugar -= Recipe.sugar;
            }
            if (IceCubes >= Recipe.icecubes)
            {
                IceCubes -= Recipe.icecubes;
            }
            if (Cups >= Recipe.cups)
            {
                Cups -= Recipe.cups;
            }                
        }


        public void DisplayWallet()
        {
            Console.WriteLine($"You have ${wallet} left");
            //double wallet = double.Parse
            Console.ReadLine();
            // return wallet;
        }
        public void DisplayInventory()
        {
            Console.WriteLine($"You have {IceCubes} Ice cubes left");
            Console.WriteLine($"You have {Sugar} sugar left");
            Console.WriteLine($"You have {Cups} cups left");
            Console.WriteLine($"You have {Lemons} lemons left");
        }
        public void IncreaseInventory(string item,double ammountToIncrease, double itemCost)
        {
            switch (item)
            {
                case "Lemons":
                    Lemons += ammountToIncrease;
                    wallet -= ammountToIncrease * itemCost;
                    break;
                case "Sugar":
                    Sugar += ammountToIncrease;
                    wallet -= ammountToIncrease * itemCost;
                    break;
                case "Ice cubes":
                    IceCubes += ammountToIncrease;
                    wallet -= ammountToIncrease * itemCost;
                    break;
                case "Cups":
                    Cups += ammountToIncrease;
                    wallet -= ammountToIncrease * itemCost;
                    break;
                default:
                    break;
            }

        }




    }
}
