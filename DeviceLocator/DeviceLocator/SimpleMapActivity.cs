﻿using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.Locations;
using Android.Util;
using System.Collections.Generic;
using System.Linq;
using Android.Gms.Drive;
using System.Text;
namespace DeviceLocator
{
	[Activity (Label = "My location tracker",  Icon = "@drawable/icon")]
    public class SimpleMapActivity : Activity, ILocationListener
	{
		//int count = 1;
        string LogTag = "DeviceLocator";
        TextView latLongDetails;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
           
            //// add map fragment to frame layout
            //var mapFragment = new MapFragment ();
            
            //FragmentTransaction fragmentTx = this.FragmentManager.BeginTransaction();
            //fragmentTx.Add(Resource.Id.linearLayout1, mapFragment, "map");
            //fragmentTx.Commit ();
            
             
			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.SimpleMap);
            InitializeLocationManager();
            InitMap();
            FindViewById<TextView>(Resource.Id.get_address_button).Click += AddressButton_OnClick;
		}

        private void InitMap()
        {
            LatLng location = new LatLng(50.897778, 3.013333);
            if ( _currentLocation != null)
            {
                location = new LatLng(_currentLocation.Latitude, _currentLocation.Longitude);
            
            }
            CameraPosition.Builder builder = CameraPosition.InvokeBuilder();
            builder.Target(location);
            builder.Zoom(10);
            builder.Bearing(155);
            builder.Tilt(65);
            CameraPosition cameraPosition = builder.Build();
            CameraUpdate cameraUpdate = CameraUpdateFactory.NewCameraPosition(cameraPosition);
          //  MapFragment mapFrag = (MapFragment)FragmentManager.FindFragmentByTag("map");
            MapFragment mapFrag = (MapFragment)FragmentManager.FindFragmentById(Resource.Id.mapZoom);
        
            GoogleMap map = mapFrag.Map;
            if (map != null)
            {
                map.MoveCamera(cameraUpdate);
                MarkerOptions markerOpt1 = new MarkerOptions();
                markerOpt1.SetPosition(location);
                markerOpt1.SetTitle("My Location");
                map.AddMarker(markerOpt1);
            }

        }


        async void AddressButton_OnClick(object sender, EventArgs eventArgs)
        {
            latLongDetails = FindViewById<TextView>(Resource.Id.latLongDetails);
            latLongDetails.Text = "Unable to determine the address.";
            LatLng location = new LatLng(34.0500, -120.0000);
            Geocoder geocoder = new Geocoder(this);
            StringBuilder deviceAddress = new StringBuilder();
            if (geocoder != null)
            {
                IList<Address> addressList = await geocoder.GetFromLocationAsync(location.Latitude, location.Longitude, 10);

                //Address address = addressList.FirstOrDefault();

                foreach (Address address in addressList)
                {

                    if (address != null)
                    {

                        for (int i = 0; i < address.MaxAddressLineIndex; i++)
                        {
                            deviceAddress.Append(address.GetAddressLine(i));


                        }
                        deviceAddress.Append("Latitude:" + address.Latitude)
                                    .Append("Latitude:" + address.Longitude)
                                     .AppendLine(",");


                    }
                    else
                    {
                        latLongDetails.Text = "Unable to determine the address.";
                    }
                }


                latLongDetails.Text = deviceAddress.ToString();
                // }
            }
        }

        Location _currentLocation;
        LocationManager _locationManager;

        String _locationProvider;

        #region location
        public void OnLocationChanged(Location location)
        {
            _currentLocation = location;

        }

        public void OnProviderDisabled(string provider)
        {
        }

        public void OnProviderEnabled(string provider)
        {
        }

        public void OnStatusChanged(string provider, Availability status, Bundle extras)
        {
            Log.Debug(LogTag, "{0}, {1}", provider, status);
        }
        void InitializeLocationManager()
        {
            _locationManager = (LocationManager)GetSystemService(LocationService);
            Criteria criteriaForLocationService = new Criteria
            {
                Accuracy = Accuracy.Fine
            };
            IList<string> acceptableLocationProviders = _locationManager.GetProviders(criteriaForLocationService, true);

            if (acceptableLocationProviders.Any())
            {
                _locationProvider = acceptableLocationProviders.First();
            }
            else
            {
                _locationProvider = String.Empty;
            }
        }

        protected override void OnResume()
        {
            base.OnResume();
            _locationManager.RequestLocationUpdates(_locationProvider, 0, 0, this);
            Log.Debug(LogTag, "Listening for location updates using " + _locationProvider + ".");
        }

        protected override void OnPause()
        {
            base.OnPause();
            _locationManager.RemoveUpdates(this);
            Log.Debug(LogTag, "No longer listening for location updates.");
        }


        #endregion
	}
}


