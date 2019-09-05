using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Project_fr
{
    class inventory
    {
        public int InventoryPurchasing; //reciepe
        public double IceCubes;
        public double Sugar;
        public double Cups;
        public double Lemons;
        public double Wallet;
        public inventory()
        {

            Wallet = 20;
        }
        public void DisplayInventory()
        {
            Console.WriteLine($"You have {IceCubes} left");
            Console.WriteLine($"You have {Sugar} left");
            Console.WriteLine($"You have {Cups} left");
            Console.WriteLine($"You have {Lemons} left");
        }
        public void IncreaseInventory(string item,double ammountToIncrease, double itemCost)
        {
            switch (item)
            {
                case "Lemons":
                    Lemons += ammountToIncrease;
                    Wallet -= ammountToIncrease * itemCost;
                    break;
                case "Sugar":
                    Sugar += ammountToIncrease;
                    Wallet -= ammountToIncrease * itemCost;
                    break;
                case "Ice Cubes":
                    IceCubes += ammountToIncrease;
                    Wallet -= ammountToIncrease * itemCost;
                    break;
                case "Cups":
                    Cups += ammountToIncrease;
                    Wallet -= ammountToIncrease * itemCost;
                    break;
                default:
                    //// TODO. Make default
                    break;
            }

        }




    }
}
