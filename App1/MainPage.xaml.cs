using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }



        async private void GetWeather_Clicked(object sender, System.EventArgs e)
        {
            try {
                Weather weather = await Core.GetWeather(entryZip.Text);
                labelLocation.Text = weather.Title;
                labelTemperature.Text = weather.Temperature;
                labelWindSpeed.Text = weather.Wind;
                labelHumidity.Text = weather.Humidity;
                labelVisibility.Text = weather.Visibility;
                labelTimeOfSunrise.Text = weather.Sunrise;
                labelTimeOfSunset.Text = weather.Sunset;
            } catch (Exception error)
            {
                var errorString = "Ocorreu algum erro na API" + error;
               await DisplayAlert("Error", (string)errorString, "Ok");
            }         
        }
    }
}
