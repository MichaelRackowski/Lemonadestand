using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Project_fr
{
    class weather
    {
       public int actualTemperature;
       public int forecastedTemperature;
        public List<string> conditionOptions;
        Random random;
        public string condition;
        public int numberOfCustomers;
        public int actualTempature;
        public string customersChoice;



 

        public void forecastedTemperatureCreator()
        {
            forecastedTemperature = random.Next(60, 100);
            Console.ReadLine();
        }
        public void conditionCreator()
        {
            conditionOptions = new List<string>() {"Humid", "Cloudy", "Sunny", "Rainy", };
         
            Random RNG = new Random();
            int index = RNG.Next(conditionOptions.Count);
            condition = conditionOptions[index];
             Console.ReadLine();
        }

        public void actualTemperatureCreator()
        {
            actualTemperature = random.Next(forecastedTemperature - 5 , forecastedTemperature + 5);             
        }

        public void customerTemperatureCreator()
        {
            if (actualTemperature > 59 && actualTemperature < 78)
            {
                numberOfCustomers = random.Next(5, 15);
            }
            else if (actualTemperature > 78 && actualTemperature < 85)
            {
                numberOfCustomers = random.Next(8, 18);
            }

            else if (actualTemperature > 85 && actualTemperature < 101)
            {
                numberOfCustomers = random.Next(11, 25);
            }

        }
       

    }
}









