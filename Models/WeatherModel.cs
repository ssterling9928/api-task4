using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Runtime;

class WeatherModel()
{
    [JsonPropertyName("main")]
    public MainWeather? Main { get; set; }

    [JsonPropertyName("weather")]
    public List<Weather>? Weather { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("coord")]
    public Coord? Coord { get; set; }
}
