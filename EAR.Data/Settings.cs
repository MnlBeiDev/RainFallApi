using System.Net;

namespace EAR.Data
{
    public class Settings
    {
        public static string BuildEnv { get; private set; }
        public static string BaseApiUrl { get; private set; }
        public static string GetApiUrl { get; private set; }
        static Settings()
        {
            BuildEnv = "DEV";
            BaseApiUrl = @"https://environment.data.gov.uk/flood-monitoring";
            GetApiUrl = $"{BaseApiUrl}/id/stations/";
        }
    }
}