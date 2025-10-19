using System.Net.Http.Json;

/// <summary> /////////////////////////////////////////////////////////////////////////////
/// ///
/// Class: WeatherService()
/// Description: Class used for API calls to OpenWeather
/// ///
/// </summary> ////////////////////////////////////////////////////////////////////////////
class WeatherService()
{
    private readonly HttpClient _httpClient = new();
    private readonly string _appId = "c7d68dba4237669f56dbf3f3e73271d1";
    private readonly string _units = "imperial";

    // Async method used to create the WeatherModel from JSON deserialization
    public async Task<WeatherModel> GetWeatherAsync(string cityName, string stateCode, string countryCode = "US")
    {
        // calls async method for the GeoCoding, used to first determine the coordinates of given location.
        // API weather calls directly from city and zipcodes are deprecated.  
        var geo = await GetGeoAsync(cityName, stateCode, countryCode);

        // create API string url
        string url = "https://api.openweathermap.org/data/2.5/weather?" + $"lat={geo.Latitude}&lon={geo.Longitude}&units={_units}&appid={_appId}";
        
        // perform API call using created url, deserializes data, stores in local variable
        var response = await _httpClient.GetFromJsonAsync<WeatherModel>(url);

        // return local variable or throw exception if failed
        return response ?? throw new InvalidOperationException("Failed to deserialize weather data.");
        
    }

    // Async method used to create the GeoModel from JSON deserialization
    public async Task<GeoModel> GetGeoAsync(string cityName, string stateCode, string countryCode = "US")
    {
        // create API string url
        string url = "https://api.openweathermap.org/geo/1.0/direct?q=" + $"{cityName},{stateCode},{countryCode}&appid={_appId}";

        // perform API call using created url, deserializes data, stores in local variable
        var response = await _httpClient.GetFromJsonAsync<List<GeoModel>>(url);

        // data deserializes into a List of GeoModels, fails if null or count is 0
        if (response is null || response.Count == 0)
            throw new InvalidOperationException("Failed to deserialize data.");

        // return local variable, only return first object
        return response[0];
    }
}