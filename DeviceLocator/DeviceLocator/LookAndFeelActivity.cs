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
using Android.Gms.Common;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;


namespace DeviceLocator
{
    [Activity(Label = "Customize map settings")]
    public class LookAndFeelActivity : Activity
    {
        private static readonly LatLng Passchendaele = new LatLng(50.897778, 3.013333);
        private static readonly LatLng VimyRidge = new LatLng(50.379444, 2.773611);
        private GoogleMap _map;
        private MapFragment _mapFragment;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
            SetContentView(Resource.Layout.LookAndFeel);
            InitMap();
           // SetupMapIfNeeded();
            SetupAnimateToButton();
            SetupZoomInButton();
            SetupZoomOutButton();
            SetupMarker();
        }

        private void InitMap()
        {
            LatLng location = new LatLng(50.897778, 3.013333);
            
            CameraPosition.Builder builder = CameraPosition.InvokeBuilder();
            builder.Target(location);
            builder.Zoom(10);
            builder.Bearing(155);
            builder.Tilt(65);
            CameraPosition cameraPosition = builder.Build();
            CameraUpdate cameraUpdate = CameraUpdateFactory.NewCameraPosition(cameraPosition);
            //  MapFragment mapFrag = (MapFragment)FragmentManager.FindFragmentByTag("map");
            //MapFragment mapFrag = (MapFragment)FragmentManager.FindFragmentById(Resource.Id.mapZoom);
            _mapFragment = FragmentManager.FindFragmentById(Resource.Id.mapZoom) as MapFragment;
            _map = _mapFragment.Map;

            if (_map != null)
            {
                
                //MarkerOptions markerOpt1 = new MarkerOptions();
                //markerOpt1.SetPosition(VimyRidge);
                //markerOpt1.SetTitle("My Location");
                //_map.AddMarker(markerOpt1);

                //MarkerOptions marker2 = new MarkerOptions();
                //marker2.SetPosition(Passchendaele);
                //marker2.SetTitle("Passchendaele");
                //_map.AddMarker(marker2);

                // We create an instance of CameraUpdate, and move the map to it.
                  cameraUpdate = CameraUpdateFactory.NewLatLngZoom(VimyRidge, 15);

                _map.AnimateCamera(cameraUpdate);
            }

        }

        private void SetupAnimateToButton()
        {
            Button animateButton = FindViewById<Button>(Resource.Id.animateButton);
            animateButton.Click += (sender, e) =>
            {
                // Move the camera to the Passchendaele Memorial in Belgium.
                CameraPosition.Builder builder = CameraPosition.InvokeBuilder();
                builder.Target(Passchendaele);
                builder.Zoom(18);
                builder.Bearing(155);
                builder.Tilt(25);
                CameraPosition cameraPosition = builder.Build();

                // AnimateCamera provides a smooth, animation effect while moving
                // the camera to the the position.
                _map.AnimateCamera(CameraUpdateFactory.NewCameraPosition(cameraPosition));
            };
        }

        private void SetupMapIfNeeded()
        {
            if (_map == null)
            {
                _map = _mapFragment.Map;
                
                if (_map != null)
                {
                    MarkerOptions marker1 = new MarkerOptions();
                    marker1.SetPosition(VimyRidge);
                    marker1.SetTitle("Vimy Ridge");
                    _map.AddMarker(marker1);

                    MarkerOptions marker2 = new MarkerOptions();
                    marker2.SetPosition(Passchendaele);
                    marker2.SetTitle("Passchendaele");
                    _map.AddMarker(marker2);

                    // We create an instance of CameraUpdate, and move the map to it.
                    CameraUpdate cameraUpdate = CameraUpdateFactory.NewLatLngZoom(VimyRidge, 15);

                    _map.AnimateCamera(cameraUpdate);
                }
            }
        }

        private void SetupZoomInButton()
        {
            Button zoomInButton = FindViewById<Button>(Resource.Id.zoomInButton);
            zoomInButton.Click += (sender, e) => { _map.AnimateCamera(CameraUpdateFactory.ZoomIn()); };
        }

        private void SetupZoomOutButton() 
         {
            Button zoomOutButton = FindViewById<Button>(Resource.Id.zoomOutButton);
            zoomOutButton.Click += (sender, e) => { _map.AnimateCamera(CameraUpdateFactory.ZoomOut()); };
        }

            private void SetupMarker ()
            {
              Button markerButton = FindViewById<Button>(Resource.Id.markerButton);
              markerButton.Click += (sender, e) => { AddImageMarkers(); };
            }


        private void AddImageMarkers()
        {
         
           
                BitmapDescriptor icon = BitmapDescriptorFactory.FromResource(Resource.Drawable.marker2);
                MarkerOptions mapOption = new MarkerOptions()
                    .SetPosition(VimyRidge)
                    .InvokeIcon(icon)
                    .SetSnippet(String.Format("This is marker for VimyRidge."))
                    .SetTitle(String.Format("Marker VimyRidge"));
                _map.AddMarker(mapOption);
               icon = BitmapDescriptorFactory.FromResource(Resource.Drawable.marker2);
                  mapOption = new MarkerOptions()
                    .SetPosition(Passchendaele)
                    .InvokeIcon(icon)
                    .SetSnippet(String.Format("This is marker for Passchendaele"))
                    .SetTitle(String.Format("Marker Passchendaele"));
                _map.AddMarker(mapOption);
            }
        }
    }
