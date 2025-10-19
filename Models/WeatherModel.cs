using System.Text.Json.Serialization;

/// <summary> /////////////////////////////////////////////////////////////////////////////
/// ///
/// Class: WeatherModel()
/// Description: Model used for determining weather conditions from calculated geolocations,
/// /// and also conforms to JSON object deserialization.  JSON Top Level Weather Object
/// ///
/// </summary> ////////////////////////////////////////////////////////////////////////////
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
