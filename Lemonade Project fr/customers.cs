using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Project_fr
{
    class customers
    {
        public double productPrice;
        public bool customerChoice;
        

        public void ProductPrice()
        {
            Console.WriteLine("How much would you like to make your lemonade cost?");
            productPrice = double.Parse(Console.ReadLine());

        }
        public void CustomerChoice(weather weather)
        {

            if (weather.actualTemperature < 78 && productPrice > 0.20)
            {
                 customerChoice = false;


            }
           else if (weather.actualTemperature <=85 && productPrice > 0.25)
            {
                customerChoice = false;

            }

            else if (weather.actualTemperature > 85 && productPrice > 0.35)
            {
                customerChoice = false;

            }
            else
            {
                customerChoice = true;
            }


        }


    }
    

}
