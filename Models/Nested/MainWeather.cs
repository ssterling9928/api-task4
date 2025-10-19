using System.Text.Json.Serialization;

/// <summary> /////////////////////////////////////////////////////////////////////////////
/// ///
/// Class: MainWeather()
/// Description: Used for storing main temperatures in the model, and also conforms to JSON
/// /// object serialization.  JSON Main Nested Object
/// ///
/// </summary> ////////////////////////////////////////////////////////////////////////////
class MainWeather
{
    [JsonPropertyName("temp")]
    public double Temp { get; set; }

    [JsonPropertyName("feels_like")]
    public double FeelsLike { get; set; }

    [JsonPropertyName("temp_min")]
    public double TempMin { get; set; }

    [JsonPropertyName("temp_max")]
    public double TempMax { get; set; }
}
