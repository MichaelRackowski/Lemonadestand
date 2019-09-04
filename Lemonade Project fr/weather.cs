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



 

        public void tempatureCreator()
        {
            forecastedTemperature = random.Next(60, 100);
            Console.ReadLine();
        }
        public void conditionCreator()
        {
            conditionOptions = new List<string>() {"Humid", "Cloudy", "Sunny", "Rainy", };



             Console.ReadLine();
        }

        public void forecastCreator()
        {
            actualTemperature = random.Next(forecastedTemperature - 5, forecastedTemperature + 5); 
            
                
                



        }


    }
}









