using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class ForecastDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private float lastPressure;
        private float currentPressure = 1013.0f;
        private Subject weatherData;
        public ForecastDisplay(Subject weatherData) 
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Update(float temp, float humidity, float pressure)
        {
            lastPressure = currentPressure;
            currentPressure = pressure;
            Display();
        }

        public void Display()
        {
            Console.Write("Weersvoorspelling: ");
            if (currentPressure > lastPressure)
            {
                Console.WriteLine("Mooi weer komt er aan!");
            }
            else if (currentPressure == lastPressure)
            {
                Console.WriteLine("Meer van hetzelfde weer.");
            }
            else if (currentPressure < lastPressure)
            {
                Console.WriteLine("Trek je paraplu's uit de kast!");
            }
        }
    }
}
