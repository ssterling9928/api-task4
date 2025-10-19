using System.Text.Json.Serialization;

class Weather()
{
    [JsonPropertyName("id")]
    public int ID { get; set; }

    [JsonPropertyName("main")]
    public string? Main { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }
}