using Acr.UserDialogs;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace WeatherApp
{
    public partial class MainPage : ContentPage

    {

       

        public MainPage()
        {
            InitializeComponent();
            
            
            
           
        }

        private   async  void Button_Clicked(object sender, EventArgs e)
        {
            UserDialogs.Instance.ShowLoading("Loading Data...");
            String city = search.Text;

            Weather result = await Core.GetWeather(city);


            place.Text = result.Title;
            description.Text = result.description;
            temp.Text = result.Tempurature;
            humidity.Text = result.Humidity + "%";
            wind.Text = result.Wind + "m/h";

           

            sunrize.Text =  result.Sunrize;
            sunset.Text = result.Sunset;

            UserDialogs.Instance.HideLoading();



        }
    }
}
