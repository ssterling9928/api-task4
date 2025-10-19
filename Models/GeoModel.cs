using System.Text.Json.Serialization;

/// <summary> /////////////////////////////////////////////////////////////////////////////
/// ///
/// Class: GeoModel()
/// Description: Model used for determining geolocations from given City, State, and Countries,
/// /// and also conforms to JSON object deserialization.
/// ///
/// </summary> ////////////////////////////////////////////////////////////////////////////
class GeoModel()
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = "";

    [JsonPropertyName("country")]
    public string Country { get; set; } = "";

    [JsonPropertyName("state")]
    public string State { get; set; } = "";

    [JsonPropertyName("lat")]
    public double Latitude { get; set; }

    [JsonPropertyName("lon")]
    public double Longitude { get; set; }

}