using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Project_fr
{
    public class Recipe
    {
        public int lemons;
        public int sugar;
        public int icecubes;
        public int cups;

      public void RecipeSelection()
        {

            Console.WriteLine("How many of your lemons would you like to use for your lemonade?");
            lemons = int.Parse(Console.ReadLine());

            Console.WriteLine("How much of your sugar would you like to use for your lemonade?");
            sugar = int.Parse(Console.ReadLine());

            Console.WriteLine("How many of your ice cubes would you like to use for your lemonade");
           icecubes = int.Parse(Console.ReadLine());

            Console.WriteLine("How many of your cups would you like to use for your lemoade?");
           cups = int.Parse(Console.ReadLine());

        }
    }
}
