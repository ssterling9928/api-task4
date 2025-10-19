using System;

/// <summary> /////////////////////////////////////////////////////////////////////////////
/// ///
/// Class: Program()
/// Description: Entry point to program.  Used for Main function
/// ///
/// </summary> ////////////////////////////////////////////////////////////////////////////
class Program
{
    // Main function uses async to create WeatherModel. 
    static async Task Main()
    {
        // Create a new WeatherService class
        WeatherService service = new();

        // create new WeatherModel by calling the WeatherService async method
        var weather = await service.GetWeatherAsync("Anchorage", "AK", "US");

        // Unwraps all nullable properties. Will not display data if null
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

