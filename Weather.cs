using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Weather
    {
        //member variables
        public List<string> weatherConditions;
        public int temperature;
        public Random randomTemps;

        //constructor
        public Weather()
        {
            temperature = randomTemps.Next(50, 100);
            weatherConditions = new List<string>();
            weatherConditions.Add("Sunny and Clear");
            weatherConditions.Add("Rain");
            weatherConditions.Add("Overcast");
        }
    }
}
