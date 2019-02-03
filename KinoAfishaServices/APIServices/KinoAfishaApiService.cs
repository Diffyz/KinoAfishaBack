using KinoAfishaServices.Models;
using KinoAfishaServices.Resources;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace KinoAfishaServices.APIServices
{
    public class KinoAfishaApiService : IKinoAfishaApiService
    {
        public async Task<KinoAfishaModel> ReturnApiResult(string criteria)
        {

            using (var client = new HttpClient())
            {
                var uri = new Uri(URI.KinoAfishaURI);
                var response = await client.GetAsync(uri);

                string json;

                using (var content = response.Content)
                {
                    json = await content.ReadAsStringAsync();
                }

                return JsonConvert.DeserializeObject<KinoAfishaModel>(json);
            }
        }
    }
}
