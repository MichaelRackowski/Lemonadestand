using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Project_fr
{
    class customers
    {
       
        public bool customerChoice;
        

       
        public void CustomerChoice(weather weather,double productPrice)
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
