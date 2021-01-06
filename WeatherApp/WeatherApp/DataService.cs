using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;


namespace WeatherApp
{
    class DataService
    {
        public static async Task<dynamic> getDataFromService(string queryString)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(queryString);

            dynamic data = null;
            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
               
                string json = response.Content.ReadAsStringAsync().Result;
                data = JsonConvert.DeserializeObject(json);
            }else if(response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                data = null;
            }

            return data;
        }


    }
}
