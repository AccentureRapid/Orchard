using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace Orchard.SuperRocket.AdSystem.Common
{
    public static class Utilities
    {
        public static StringContent Serialize(dynamic source, HttpResponseMessage response)
        {
            var settings = new JsonSerializerSettings()
            {
                ContractResolver = new NullToEmptyStringResolver(),
                PreserveReferencesHandling = PreserveReferencesHandling.None
            };

            var stringcontent = JsonConvert.SerializeObject(source, Newtonsoft.Json.Formatting.Indented, settings);
            return new StringContent(stringcontent, Encoding.GetEncoding("UTF-8"), "application/json");
        }
    }
}