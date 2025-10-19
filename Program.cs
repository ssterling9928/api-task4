using System;
using System.Net;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        WeatherService service = new();
        var weather = await service.GetWeatherAsync("Batesville", "AR");

        if (weather.Main is not null)
        {
            Console.WriteLine($"City: {weather.Name}");
            Console.WriteLine($"Current Temp: {weather.Main.Temp}");
            Console.WriteLine($"Feels Like: {weather.Main.FeelsLike}");
            Console.WriteLine($"Min Temp: {weather.Main.TempMin}");
            Console.WriteLine($"Max Temp: {weather.Main.TempMax}");
        }
        if (weather.Weather is not null)
        {
            Console.WriteLine($"Description: {weather.Weather[0].Description}");
        }

        

    }
}

