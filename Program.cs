using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            Displays.CurrentConditionDisplay currentDisplay = new Displays.CurrentConditionDisplay(weatherData);
            Displays.StatisticsDisplay statisticsDisplay = new Displays.StatisticsDisplay(weatherData);
            Displays.ForecastDisplay forecastDisplay = new Displays.ForecastDisplay(weatherData);

            Console.WriteLine("--- Eerste meting ---");
            weatherData.SetMeasurements(currentDisplay);

            Console.WriteLine("\n--- Voorspelling ---");
            weatherData.SetMeasurements(forecastDisplay);

            Console.WriteLine("\n--- We melden StatisticsDisplay af ---");
            weatherData.RemoveObserver(statisticsDisplay);

            Console.WriteLine("\n--- Vierde meting (zonder statistieken) ---");
            weatherData.SetMeasurements(19.0f, 85f, 1010.0f);
        }
    }
}