using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAR.Data.Helpers
{
    public static class JsonHelper
    {
        /// <summary>
        /// propname is optional it used when we need to specify specific json property to be de serialize
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jsonData"></param>
        /// <param name="propName"></param>
        /// <returns></returns>
        public static object DeserializeJson<T>(string jsonData, string propName = "")
        {
            if (!string.IsNullOrEmpty(jsonData))
            {
                var json = JObject.Parse(jsonData);

                var content = JsonConvert.SerializeObject(json.Root["items"]);

                return JsonConvert.DeserializeObject<T>(content);

            }
            return JsonConvert.DeserializeObject<T>(jsonData);
        }
        
       
       
    }

}
