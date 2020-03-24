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
        public string condition;

        //constructor
        public Weather()
        {           
            weatherConditions = new List<string>();
            weatherConditions.Add("Sunny and Clear");
            weatherConditions.Add("Rain");
            weatherConditions.Add("Overcast");
            weatherConditions.Add("Mostly Sunny");
        }
        public string SetWeatherConditions()
        {
            Random randomCondition = new Random();
            int randomWeather = randomCondition.Next(0, 3);
            condition = weatherConditions[randomWeather];
            Console.WriteLine($"Today's Weather Conditions: {condition}");
            return condition;
        }
        public int SetTemperature()
        {
            Random randomTemp = new Random();
            temperature = randomTemp.Next(50, 100);
            Console.WriteLine($"Today's Temperature: {temperature}");
            return temperature;
        }
    }
}
