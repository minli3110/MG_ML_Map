using MG;
using MG.ChineseCuisines;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;
using System;

namespace MG
{
    public partial class MyApp : ContentPage
    {
        public MyApp()
        {
            // Define the current location
            var currentLocation = new Location(1.280690, 103.846350);

            // Create a new map
            var map = new Microsoft.Maui.Controls.Maps.Map();

            // Set the initial map region
            map.MoveToRegion(MapSpan.FromCenterAndRadius(currentLocation, Distance.FromKilometers(1)));

            // Add a pin for the current location
            var pin = new Pin
            {
                Label = "Tian Tian Chicken Rice",
                Address = "1 Kadayanallur St, Singapore 069184",
                Location = currentLocation
            };
            map.Pins.Add(pin);

            // Add the map to the page
            Content = new StackLayout
            {
                Children = { map }
            };
        }
        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            // Add your event handler code here
            Navigation.PushAsync(new ChickenRice());
        }  
    }
}
