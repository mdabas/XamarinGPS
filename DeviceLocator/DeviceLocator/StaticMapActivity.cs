using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.Gms.Location;
using System.Drawing;
namespace DeviceLocator
{
    [Activity(Label = "Static Map Points")]
    public class StaticMapActivity : Activity
    {
        private static readonly LatLng InMaui = new LatLng(20.72110, -156.44776);
        private static readonly LatLng LeaveFromHereToMaui = new LatLng(82.4986, -62.348);
        //private static readonly LatLng[] LocationForCustomIconMarkers = new[]
        //                                                                    {
        //                                                                        new LatLng(40.741773, -74.004986),
        //                                                                        new LatLng(41.051696, -73.545667),
        //                                                                        new LatLng(41.311197, -72.902646)
           //                                                                 };
        private static readonly LatLng[] LocationForCustomIconMarkers = new[]
                                                                            {
                                                                                new LatLng(37.0000, -120.0000),                                                         
                                                                                new LatLng(34.0500, -118.2500),                                                                               
                                                                                new LatLng(36.1215 , -115.1739 ), 
                                                                                new LatLng (40.7500 ,  -111.8833 ),
                                                                                new LatLng(39.7392,-104.9903),
                                                                                new LatLng(39.0997,- 94.5783) ,
                                                                                new LatLng(41.8369, -87.6847),
                                                                                new LatLng(40.7127,- 74.0059),
                                                                                new LatLng(42.3601, -71.0589),
                                                                            };

        private static readonly string[] LocationName = new[] { 
        "California"  ,     "Los Angeles" ,"Las Vegas","Salt Lake City","Denver" ,"Kansas City" ,"Chicago","New York", "Boston",                                                                               
                                                                            };
        private string _gotoMauiMarkerId;
        private GoogleMap _map;
        private MapFragment _mapFragment;
        private Marker _polarBearMarker;
        private GroundOverlay _polarBearOverlay;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main); 
            InitMapFragment();
            SetupMapIfNeeded();
             
        }

        //protected override void OnPause()
        //{
        //    base.OnPause();

        //    // Pause the GPS - we won't have to worry about showing the 
        //    // location.
        //    _map.MyLocationEnabled = true;
        //    _map.
        //    _map.MarkerClick -= MapOnMarkerClick;
        //}

        protected override void OnResume()
        {
            base.OnResume();

            SetupMapIfNeeded();

            _map.MyLocationEnabled = true;

            // Setup a handler for when the user clicks on a marker.
            _map.MarkerClick += MapOnMarkerClick;
        }



        private void InitMapFragment()
        {
            //
          //  _mapFragment = FragmentManager.FindFragmentByTag("map") as MapFragment;
             _mapFragment = FragmentManager.FindFragmentById<MapFragment>(Resource.Id.mapOverLay);
            GoogleMap map1 = _mapFragment.Map;

            if (_mapFragment == null)
            {
                GoogleMapOptions mapOptions = new GoogleMapOptions()
                    .InvokeMapType(GoogleMap.MapTypeSatellite)
                    .InvokeZoomControlsEnabled(false)
                    .InvokeCompassEnabled(true);

                FragmentTransaction fragTx = FragmentManager.BeginTransaction();
                _mapFragment = MapFragment.NewInstance(mapOptions);
                fragTx.Add(Resource.Id.mapWithOverlay, _mapFragment, "map");
                fragTx.Commit();
            }
            else
            {
                if (_mapFragment.Map == null)
                {
                }

            }
        }

        private void MapOnMarkerClick(object sender, GoogleMap.MarkerClickEventArgs markerClickEventArgs)
        {
            Marker marker = markerClickEventArgs.Marker;
            if (marker.Id.Equals(_gotoMauiMarkerId))
            {
                PositionPolarBearGroundOverlay(InMaui);
                _map.AnimateCamera(CameraUpdateFactory.NewLatLngZoom(InMaui, 13));
                _gotoMauiMarkerId = null;
                _polarBearMarker.Remove();
                _polarBearMarker = null;
            }
            else
            {
                int index =0 ;
                int.TryParse( marker.Id.Substring(marker.Id.Length - 1),out index);
                string city = LocationName[index];
                Toast.MakeText(this, String.Format("You clicked on  {0}", city), ToastLength.Short).Show();
            }
        }

        private void PositionPolarBearGroundOverlay(LatLng position)
        {
            if (_polarBearOverlay == null)
            {
                BitmapDescriptor image = BitmapDescriptorFactory.FromResource(Resource.Drawable.marker1);
                GroundOverlayOptions groundOverlayOptions = new GroundOverlayOptions()
                    .Position(position, 150, 200)
                    .InvokeImage(image);
                _polarBearOverlay = _map.AddGroundOverlay(groundOverlayOptions);
            }
            else
            {
                _polarBearOverlay.Position = InMaui;
            }
        }

        private void AddInitialPolarBarToMap()
        {
            MarkerOptions markerOptions = new MarkerOptions()
                .SetSnippet("Click me to go on vacation.")
                .SetPosition(LeaveFromHereToMaui)
                .SetTitle("Goto Maui");
            _polarBearMarker = _map.AddMarker(markerOptions);
            _polarBearMarker.ShowInfoWindow();

            _gotoMauiMarkerId = _polarBearMarker.Id;

            PositionPolarBearGroundOverlay(LeaveFromHereToMaui);
        }

        /// <summary>
        ///   Add three markers to the map.
        /// </summary>
        private void AddCustomMarkersToMap()
        {
            PolylineOptions rectOptions = new PolylineOptions()
            .InvokeColor(Color.Red.ToArgb())
             .InvokeWidth(5)
             .InvokeZIndex(10)
             .Geodesic(true);
             
            for (int i = 0; i < LocationForCustomIconMarkers.Length; i++)
            {
                BitmapDescriptor icon = BitmapDescriptorFactory.FromResource(Resource.Drawable.marker1);
                MarkerOptions mapOption = new MarkerOptions()
                    .SetPosition(LocationForCustomIconMarkers[i])
                    .InvokeIcon(icon)
                    .SetSnippet(String.Format("This is marker for .", LocationName[i]))
                    .SetTitle(String.Format("Marker {0}",LocationName[i])); 
                _map.AddMarker(mapOption);
                rectOptions.Add(LocationForCustomIconMarkers[i]);

            }
            
            _map.AddPolyline(rectOptions);
        }
        private void SetupMapIfNeeded()
        {
            if (_map == null)
            {
                _map = _mapFragment.Map;
                if (_map != null)
                {
                    AddCustomMarkersToMap();
                    AddInitialPolarBarToMap();

                    // Move the map so that it is showing the markers we added above.
                    _map.AnimateCamera(CameraUpdateFactory.NewLatLngZoom(LocationForCustomIconMarkers[3], 4));
                }
            }
        }
    }
}