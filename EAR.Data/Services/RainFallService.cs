using EAR.Common.Models;
using EAR.Data.Helpers;
using EAR.Data.Interfaces;
using System.Net;
using System.Net.Http;

namespace EAR.Data.Services
{
    public class RainFallService : IRainFallService
    {
        private readonly IDataService _dataService;

        public RainFallService(IDataService dataService)
        {
            _dataService = dataService;
        }

        public async Task<List<RainFallReading>> GetRainFallReadingsByStoreId(string id, string limit)
        {
            string url = $"{Settings.GetApiUrl}/{id}/readings?_sorted&_limit={limit}";

            var content = await _dataService.GetDataAsync(url);

            if(content == null)
            {
                return new List<RainFallReading>();
            }

            var result = JsonHelper.DeserializeJson<List<RainFallReading>>(content, "items");

            return (List<RainFallReading>)result;
        }
    }
}