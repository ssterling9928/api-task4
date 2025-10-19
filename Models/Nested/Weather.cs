using System.Text.Json.Serialization;

/// <summary> /////////////////////////////////////////////////////////////////////////////
/// ///
/// Class: Weather()
/// Description: Used for storing descriptions in the model, and also conforms to JSON
/// /// object serialization.  JSON Weather Nested Object
/// ///
/// </summary> ////////////////////////////////////////////////////////////////////////////
class Weather()
{
    [JsonPropertyName("id")]
    public int ID { get; set; }

    [JsonPropertyName("main")]
    public string? Main { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }
}