using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Windows.Devices.Geolocation;
using System.Device.Location;
using System.Threading.Tasks;
using Microsoft.Phone.Maps.Controls;
using Microsoft.Phone.Maps.Toolkit;
using Microsoft.Phone.Maps.Services;
using System.Windows.Media;
using System.Reflection;
using System.Threading;

namespace SampleMapApp
{
    public partial class MapPage : PhoneApplicationPage
    {
        RouteQuery MyQuery = null;
        GeocodeQuery Mygeocodequery = null;

        public MapPage()
        {
            InitializeComponent();

        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            await ShowMyLocationOnTheMap();

        }
        List<GeoCoordinate> MyCoordinates = new List<GeoCoordinate>();

        private async Task ShowMyLocationOnTheMap()
        {
            Geolocator myGeolocator = new Geolocator();
            Geoposition myGeoposition = await myGeolocator.GetGeopositionAsync();
            Geocoordinate myGeocoordinate = myGeoposition.Coordinate;

            this.mapWithMyLocation.ZoomLevel = 6;
            // var list = MarkerPointBusinessMethods.InitializemarkerPoints();
            var list = MarkerPointBusinessMethods.InitializeMarkerPointAlgo();
            //var geoCor =  new GeoCoordinate { Latitude = list[0].Latitude, Longitude = list[0].Longitude };
            GeoCoordinate myGeoCoordinate =
            new GeoCoordinate { Longitude = list[0].Longitude, Latitude = list[0].Latitude };
            this.mapWithMyLocation.Center = myGeoCoordinate;
            PinMap(this.mapWithMyLocation, myGeoCoordinate, "PushpinRedControlTemplate");

            foreach (var marker in list)
            {
                string controlTemplate = "PushpinRedControlTemplate";
                if (marker.IsOrangeMarked)
                {
                    controlTemplate = "PushpinOrangeControlTemplate";
                }
                else if (marker.IsGreenMarked)
                {
                    controlTemplate = "PushpinGreenControlTemplate";
                }
                PinMap(this.mapWithMyLocation, new GeoCoordinate { Latitude = marker.Latitude, Longitude = marker.Longitude }, controlTemplate);

            }
            this.mapWithMyLocation.Center = myGeoCoordinate;




            //this.mapWithMyLocation.AddRoute(new MapRoute{})
            var _markerPointList = MarkerPointBusinessMethods.GetAllPossiblePaths(MarkerPointBusinessMethods.InitializeMarkerPointAlgo()[1], 5);
            MyQuery = new RouteQuery();
            foreach (var marker in _markerPointList)
            {
                MyCoordinates.Add(new GeoCoordinate { Latitude = marker.Latitude, Longitude = marker.Longitude });

            }

            //MyCoordinates.Add(new GeoCoordinate { Longitude = list[0].Longitude, Latitude = list[0].Latitude });
            //MyCoordinates.Add(new GeoCoordinate { Longitude = list[1].Longitude, Latitude = list[1].Latitude });

            MyQuery.Waypoints = MyCoordinates;
            MyQuery.QueryCompleted += MyQuery_QueryCompleted;
            MyQuery.QueryAsync();

        }

        void MyQuery_QueryCompleted(object sender, QueryCompletedEventArgs<Route> e)
        {
            try
            {
                Route MyRoute = e.Result;
                MapRoute MyMapRoute = new MapRoute(MyRoute);
                MyMapRoute.OutlineColor = Colors.Red;
                MyMapRoute.Color = Colors.Red;
                this.mapWithMyLocation.AddRoute(MyMapRoute);
                MyQuery.Dispose();
            }

            catch (TargetInvocationException)
            {
                Thread.Sleep(1000); // waiting for  completing the query
                MyQuery_QueryCompleted(sender, e);
            }

        }

        public void PinMap(Map map, GeoCoordinate geoPosition, string controlTemplate)
        {

            //   map.ZoomLevel = 13;

            var mapOverlay = new MapOverlay();
            Pushpin mypin = new Pushpin();

            mypin.Template = this.Resources[controlTemplate] as ControlTemplate;
            mapOverlay.Content = mypin;
            mapOverlay.GeoCoordinate = geoPosition;

            var mapLayer = new MapLayer();
            mapLayer.Add(mapOverlay);

            map.Layers.Add(mapLayer);
        }
    }
}