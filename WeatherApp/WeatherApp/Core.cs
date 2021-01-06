using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace WeatherApp
{
    class Core
    {
        public static  async Task<Weather> GetWeather(string city)
        {
            string key = "5284fcb324d66054643af9c58136714f";
            string queryString = "https://api.openweathermap.org/data/2.5/weather?q=" + city + "&units=metric&appid=" + key;

            dynamic results = await DataService.getDataFromService(queryString).ConfigureAwait(false);

            Weather weather = new Weather();
          
            
            if (results != null)
            {
                weather.Title = results["name"];
                weather.Tempurature = results["main"]["temp"];
                weather.Humidity = results["main"]["humidity"];
                weather.Wind = results["wind"]["speed"];
                 weather.description = results["weather"][0]["description"];
                       

                weather.Sunrize = ConvertFromUnixTimestamp((double)results["sys"]["sunrise"]).ToString("HH:mm");
                weather.Sunset = ConvertFromUnixTimestamp((double)results["sys"]["sunset"]).ToString("HH:mm");

                return weather;
            }

            return weather;

            
        }

       

        public static DateTime ConvertFromUnixTimestamp(double timestamp)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return origin.AddSeconds(timestamp);
        }
    }
}
