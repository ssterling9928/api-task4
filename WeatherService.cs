using System;
using System.Net.Http.Json;

class WeatherService()
{
    private readonly HttpClient _httpClient = new();
    private readonly string _appId = "c7d68dba4237669f56dbf3f3e73271d1";
    private readonly string _units = "imperial";

    public async Task<WeatherModel> GetWeatherAsync(string cityName, string stateCode, string countryCode = "US")
    {
        var geo = await GetGeoAsync(cityName, stateCode, countryCode);

        string url = "https://api.openweathermap.org/data/2.5/weather?" + $"lat={geo.Latitude}&lon={geo.Longitude}" + $"&units={_units}" + "&appid=" + _appId;

        var response = await _httpClient.GetFromJsonAsync<WeatherModel>(url);

        return response ?? throw new InvalidOperationException("Failed to deserialize weather data.");
        
    }

    public async Task<GeoModel> GetGeoAsync(string cityName, string stateCode, string countryCode = "US")
    {
        string url = "https://api.openweathermap.org/geo/1.0/direct?q=" + $"{cityName},{stateCode},{countryCode}" + "&appid=" + _appId;

        var response = await _httpClient.GetFromJsonAsync<List<GeoModel>>(url);

        return response[0] ?? throw new InvalidOperationException("Failed to deserialize data.");
    }
}