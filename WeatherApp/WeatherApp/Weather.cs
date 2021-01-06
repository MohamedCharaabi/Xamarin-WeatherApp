

namespace WeatherApp
{
    public class Weather
    {
        public string Title { get; set; }
        public string Tempurature { get; set; }
        public string Wind { get; set; }
        public string Humidity { get; set; }
        public string Visibility { get; set; }
        public string Sunrize { get; set; }
        public string Sunset { get; set; }
        public string description { get; set; }


        public Weather(){
            this.Title = " ";
            this.Tempurature = " ";
            this.Wind = " ";
            this.Humidity = " ";
            this.Visibility = " ";
            this.Sunrize = " ";
            this.Sunset = " ";
            this.description = "";
        }

    }
}
