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
        customers customer;

        public void DailyOutcome()
        {

        }
        public void runDay()
        {
            /// put methods of how i want my day to go from morning to night then put runDay in runGame method
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
        public void creatCustomer()
        {
            for (int i = 0; i < weather.numberOfCustomers; i++)
            {
                customer = new customers();
                customer.CustomerChoice(weather);
                if (customer.customerChoice)
                {
                    buyingCustomers.Add(customer);
                }
            }

        }
    }

   
}
