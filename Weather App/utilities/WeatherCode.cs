namespace Weather_App.utilities
{
    public static class WeatherCode
    {
        public static string Convert(int code)
        {
            switch(code)
            {
                case 0:
                    return "Clear Sky";
                case 1:
                    return "Mainly Clear";
                case 2:
                    return "Partly Cloudy";
                case 3:
                    return "Overcast";
                case 45:
                    return "Fog";
                case 48:
                    return "Depositing rime fog";
                case 51:
                    return "Drizzle: Light";
                case 85:
                    return "Snow showers: Heavy";
                case 86:
                    return "Snow showers: Heavy";
                case 95:
                    return "Thunderstorm: Slight or moderate";
                case 96:
                case 99:
                    return "Thunderstorm with slight and heavy hail";
                default: return "Unknown";

            }
        }
    }
}
