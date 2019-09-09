using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Project_fr
{

    class Day
    {
        public List<customers> buyingCustomers = new List<customers>();
        weather weather = new weather();
        inventory inventory;
        public double productPrice;




        public void runDay()
        {

            weather.forecastedTemperatureCreator();
            weather.actualTemperatureCreator();
           weather.customerTemperatureCreator();
            weather.conditionCreator();
            inventory.DisplayInventory();
            inventory.DisplayWallet();
            DisplayStore();
            //inventory.IncreaseInventory("", 0, 0);
            ProductPrice();
            createCustomer();
            for(int i = 0; i < 9)



            CustomerChoice();
            decreaseInventory(inventory inventory, string item, double ammountToDecrease);
            DailyOutcome();
        }
        public void ProductPrice()
        {
            Console.WriteLine("How much would you like to make your lemonade cost?");
            productPrice = double.Parse(Console.ReadLine());

        }

        public void decreseInventory(inventory inventory, string item, double ammountToDecrease)
        {
            switch (item)
            {
                case "Lemons":
                    inventory.Lemons -= ammountToDecrease;
                    break;
                case "Sugar":
                    inventory.Sugar -= ammountToDecrease;
                    break;
                case "Ice Cubes":
                    inventory.IceCubes -= ammountToDecrease;
                    break;
                case "Cups":
                    inventory.Cups -= ammountToDecrease;
                    break;
                default:
                    break;
            }


        }
        public void createCustomer()
        {
            for (int i = 0; i < weather.numberOfCustomers; i++)
            {
                customers customer = new customers();
                buyingCustomers.Add(customer);
            }

        }
    }

   
}
