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
        public double productPrice;
        Recipe recipe = new Recipe();
        public int cupsSold = 0;

        
        




        public void runDay(Store store, Player player) //Recipe Recipe

        {
           weather.forecastedTemperatureCreator();
            weather.actualTemperatureCreator();
           weather.customerTemperatureCreator();
            weather.conditionCreator();
            weather.DisplayForecastedWeather();
            weather.DisplayActualWeather();
            player.inventory.DisplayInventory();
            player.inventory.DisplayWallet();
            store.DisplayStore(player);
            ProductPrice();
            createCustomer();
             
            for(int i = 0; i < buyingCustomers.Count; i++)
            {
                buyingCustomers[i].CustomerChoice(weather,productPrice);

                if(buyingCustomers[i].customerChoice)
                {
                    cupsSold++;
                }
            }
            player.recipe.RecipeSelection();
            player.inventory.RecipeSubtractor(player.recipe);
            int lemonsToRemove = recipe.lemons * cupsSold;
            int sugarToRemove = recipe.sugar * cupsSold;
            int icecubesToRemove = recipe.icecubes * cupsSold;
            int cupsToRemove = recipe.cups * cupsSold;
            decreseInventory(player.inventory, "lemon", lemonsToRemove);
            decreseInventory(player.inventory, "sugar", sugarToRemove);    // rearrange to make more sense, test it to make sure it works once I rearrange. 
            decreseInventory(player.inventory, "cups", icecubesToRemove);
            decreseInventory(player.inventory, "ice cubes", cupsToRemove);
            AddMoney(player);
            DailyOutcome(player);
        }
        public void AddMoney(Player player)
        {
           double money = productPrice * cupsSold;
           player.inventory.wallet += money;
        }
        public void ProductPrice()
        {
            Console.WriteLine("How much would you like to make your lemonade cost?");
            productPrice = double.Parse(Console.ReadLine());

        }
        public void DailyOutcome(Player player)
        {
           player.inventory.DisplayWallet();
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
