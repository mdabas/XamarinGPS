using Bing.Maps;
using Bing.Maps.Directions;
using SampleMapApp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SampleMapAppWindows8
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Geolocator _geolocator = null;
        public MainPage()
        {
            this.InitializeComponent();
            _geolocator = new Geolocator();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            Geoposition pos = await _geolocator.GetGeopositionAsync().AsTask();

            var markerPoints = MarkerPointBusinessMethods.InitializemarkerPoints();

            foreach (var marker in markerPoints)
            {
                string template = "PushpinRedControlTemplate";
                if ((marker.EndTime - marker.StartTime).Minutes > 5 && (marker.EndTime - marker.StartTime).Minutes <= 10)
                {
                    template = "PushpinOrangeControlTemplate";
                }
                if ((marker.EndTime - marker.StartTime).Minutes > 10)
                {
                    template = "PushpinGreenControlTemplate";
                }
                CreatePushpin(marker.Latitude, marker.Longitude, template);

            }
            Location location = new Location(markerPoints[0].Latitude, markerPoints[0].Longitude);
            WaypointCollection waypoints = new WaypointCollection();
            waypoints.Add(new Waypoint(new Location { Latitude = markerPoints[0].Latitude, Longitude = markerPoints[0].Longitude }));
            waypoints.Add(new Waypoint(new Location { Latitude = markerPoints[1].Latitude, Longitude = markerPoints[1].Longitude }));
            DirectionsManager directionManager = this.myMap.DirectionsManager;
            directionManager.Waypoints = waypoints;

            DirectionsRenderOptions directionsRender = new DirectionsRenderOptions();
            Color color = new Color();
            color.A = 255;
            color.R = 255;
            color.G = 0;
            color.B = 0;
            Brush brush = new SolidColorBrush(color);
            DirectionsPolylineRenderOptions directionsPolyRender = new DirectionsPolylineRenderOptions(color, 50, true);
            directionsPolyRender.Visible = true;
            directionsRender.ActiveRoutePolylineOptions = directionsPolyRender;
            directionManager.RenderOptions = directionsRender;  
            RouteResponse response = await directionManager.CalculateDirectionsAsync();
            directionManager.ShowRoutePath(response.Routes[0]);

            this.myMap.SetView(location);
            this.myMap.ZoomLevel = this.myMap.ZoomLevel * 0.85;
        }

        private void CreatePushpin(double latitude, double longitude, string pinTemplate)
        {
            Pushpin pushpin = new Pushpin();
            pushpin.Template = Resources[pinTemplate] as ControlTemplate;
            // pushpin.Text = "1";
            MapLayer.SetPosition(pushpin, new Location(latitude, longitude));
            this.myMap.Children.Add(pushpin);
        }
    }
}
