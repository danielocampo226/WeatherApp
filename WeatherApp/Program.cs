using Newtonsoft.Json.Linq;
using System;
using System.IO;
using WeatherApp;

namespace WeatherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = File.ReadAllText("appsetting.json");
            string APIKey = JObject.Parse(key).GetValue("APIKey").ToString();

            Console.WriteLine("Please enter your zipcode");
            var zipCode = Console.ReadLine();

            var apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={APIKey}";

            Console.WriteLine();

            Console.WriteLine($"It is currently {WeatherMap.GetTemp(apiCall)} degrees F in your location");
        }
    }
}