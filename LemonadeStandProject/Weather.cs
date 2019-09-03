using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStandProject
{
    public class Weather
    {
        public List<string> weather;

        public Weather Weather

            Random RNG = new Random();
        int index = RNG.Next(WeatherOptions.count);
        Weather = WeatherOptions[index];
        
        weather = new List<string>();
            weather.Add("It's 95 and Humid!");
            weather.Add("It's 85 and Sunny!");
            weather.Add("It's 75 and Raining!");
            weather.Add("It's 60 and windy!");
    }
}