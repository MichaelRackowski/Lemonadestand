using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Project_fr
{
    class game
    {
        Day day = new Day();
        Player player = new Player();
        Store store;
        


        
        public int numbersOfDayToPlay;
        public game()
        {
            store = new Store(player);

        }


        public void runGame()
        {
            Console.WriteLine("How many days would you like to play? Recomended 7 days");
            numbersOfDayToPlay = int.Parse(Console.ReadLine());
            runNumbersOfDay();
            day.runDay(store, player);

          
        }
       
        public void DislpayForeCast(int thing) ////single responsabilty
        {
            for (int i = thing; i < 8; i++)
            {

            }
        }

        public void runNumbersOfDay()
        {
            for(int i = 1; i < 8; i++)
            {
                day = new Day();
                DislpayForeCast(i);
                day.runDay(store,player);
                Console.WriteLine($"Day {i}");  /// single responsability
            }


        }



    }

}
