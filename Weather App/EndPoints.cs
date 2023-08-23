namespace Weather_App
{
    public class EndPoints
    {
        public static string GetGeoApifyEndpoint(string cityName)
        {
            return $"https://api.geoapify.com/v1/geocode/search?text={cityName}&format=json&apiKey={Config.GeoApifyKey}";
        }

        public static string GetWeatherEndpoint(float lat, float lon)
        {
            return $"https://api.open-meteo.com/v1/forecast?latitude={lat}&longitude={lon}&daily=weathercode,apparent_temperature_max,apparent_temperature_min&current_weather=true&timezone=America%2FNew_York";
        }
    }
}
