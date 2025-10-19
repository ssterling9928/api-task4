using System.Text.Json.Serialization;

/// <summary> /////////////////////////////////////////////////////////////////////////////
/// ///
/// Class: Coord()
/// Description: Used for storing lat and long inside the model, and also conforms to JSON
/// /// object serialization.  JSON Coord Nested Object
/// ///
/// </summary> ////////////////////////////////////////////////////////////////////////////
class Coord
{
    [JsonPropertyName("lon")]
    public double Longitude { get; set; }

    [JsonPropertyName("lat")]
    public double Latitude { get; set; }
}