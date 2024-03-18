using EAR.Data.Interfaces;
using System.Net;
using System.Net.Http;

namespace EAR.Data.Services
{
    public class DataService : IDataService, IDisposable
    {
        private HttpClient httpClient;

        public async Task<string> GetDataAsync(string url)
        {
            string data = string.Empty;

            try
            {
                using (httpClient = new HttpClient())
                {
                    var res = await httpClient.GetAsync(url);

                    var content = res.Content;

                    data = await content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return data;
        }

        public void Dispose()
        {
            httpClient?.Dispose();
            httpClient = null;
        }

    }
}