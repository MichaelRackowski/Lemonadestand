﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Project_fr
{
    class game
    {
        Day day = new Day();
        player player = new player();
        store store;
        
        public int numbersOfDayToPlay;
        public game()
        {
            store = new store(player);
        }


        public void runGame()
        {
            Console.WriteLine("How many days would you like to play? Recomended 7 days");
            numbersOfDayToPlay = int.Parse(Console.ReadLine());
            
          
            

        }

        public void runNumbersOfDay()
        {
            for(int i = 1; i < 8; i++)
            {
                day = new Day();
                day.runDay();
                Console.WriteLine($"Day {i}");
            }


        }



    }

}
