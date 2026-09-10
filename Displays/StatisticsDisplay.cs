using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class StatisticsDisplay : WeatherDisplay
    {
        private float sumTemperature = 0;
        private float maxTemp = 0;
        private float minTemp = 0;
        private int countUpdated = 0;
        public StatisticsDisplay(Subject weatherData) : base(weatherData){ }

        public override void Display()
        { 
            if (Temperature > maxTemp)
            {
                maxTemp = Temperature;
            }

            if (Temperature < minTemp || ( countUpdated == 0 && minTemp == 0))
            {
                minTemp = Temperature;
            }

            Console.WriteLine($"Average/Maximum/Minimum: {sumTemperature}/{maxTemp}/{minTemp}");
        }
    }
}
