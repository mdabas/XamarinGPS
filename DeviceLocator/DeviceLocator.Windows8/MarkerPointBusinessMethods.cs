using Bing.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMapApp
{
   public static class MarkerPointBusinessMethods
    {
       static List<MarkerPoint> markerPoints = new List<MarkerPoint>(); 
       public static List<MarkerPoint> InitializemarkerPoints()
       {
           

           markerPoints = new List<MarkerPoint>();
           MarkerPoint p = new MarkerPoint()
           {
               Latitude = 37.0000,
               Longitude = -120.0000,
               AreaName = "California",
              

           };
          // markerPoints.Add(p);
           p = new MarkerPoint()
           {

               Latitude = 34.0500,
               Longitude = -118.2500,
               AreaName = "Los Angeles",
                StartTime=new TimeSpan(1,20,0),
                EndTime= new TimeSpan(1,23,0)
           };
           markerPoints.Add(p);
           p = new MarkerPoint()
           {

               Latitude = 34.050669,

               Longitude = -118.251059,
               AreaName = "Los Angeles",
               StartTime = new TimeSpan(1, 20, 0),
               EndTime = new TimeSpan(1, 24, 0)

           };
           markerPoints.Add(p);

           p = new MarkerPoint()
           {

               Latitude = 34.048707,

               Longitude = -118.250236,
               AreaName = "Los Angeles",
               StartTime = new TimeSpan(1, 20, 0),
               EndTime = new TimeSpan(1, 28, 0)

           };
           markerPoints.Add(p);

           p = new MarkerPoint()
           {

               Latitude = 34.049160,

               Longitude = -118.250912,
               AreaName = "Los Angeles",
               StartTime = new TimeSpan(1, 20, 0),
               EndTime = new TimeSpan(1, 28, 0)

           };
           markerPoints.Add(p);


           p = new MarkerPoint()
           {

               Latitude = 34.050031,
               Longitude = -118.250654,
               AreaName = "Los Angeles",
               StartTime = new TimeSpan(1, 20, 0),
               EndTime = new TimeSpan(1, 35, 0)

           };
           markerPoints.Add(p);

           p = new MarkerPoint()
           {

               Latitude = 34.049578,
               Longitude = -118.250848,
               AreaName = "Los Angeles",
               StartTime = new TimeSpan(1, 20, 0),
               EndTime = new TimeSpan(1, 35, 0)

           };
           markerPoints.Add(p);

           p = new MarkerPoint()
           {

               Latitude = 36.1215,
               Longitude = -115.1739,
               AreaName = "Las Vegas"

           };
          // markerPoints.Add(p);

           p = new MarkerPoint()
           {

               Latitude = 40.7500,
               Longitude = -111.8833,
               AreaName = "Salt Lake City"
           };
          // markerPoints.Add(p);

           p = new MarkerPoint()
           {

               Latitude = 39.7392,
               Longitude = -104.9903,
               AreaName = "Denver"
           };
           //markerPoints.Add(p);

           p = new MarkerPoint()
           {

               Latitude = 39.0997,
               Longitude = -94.5783,
               AreaName = "Kansas City"
           };
          // markerPoints.Add(p);

           p = new MarkerPoint()
           {

               Latitude = 41.8369,
               Longitude = -87.6847,
               AreaName = "Chicago"
           };
          // markerPoints.Add(p);
           p = new MarkerPoint()
           {

               Latitude = 40.7127,
               Longitude = -74.0059,
               AreaName = "New York"
           };
           //markerPoints.Add(p);
           p = new MarkerPoint()
           {

               Latitude = 42.3601,
               Longitude = -71.0589,
               AreaName = "Boston"
           };
          // markerPoints.Add(p);
           //RearrangeTimings(ref markerPoints);
           return markerPoints;
           //markerPoints.Add(slot);
           //CalculateDistancesAdjustantPoints(markerPoints);
           //DeviceLocatorManager d = new DeviceLocatorManager();
           //d.RearrangeTimings(ref markerPoints);

           return markerPoints;
       }
    }

   public class MarkerPoint
   {
       public int Id { get; set; }
       public double Latitude { get; set; }
       public double Longitude { get; set; }
       public string AreaName { get; set; }
       public TimeSpan StartTime { get; set; }
       public TimeSpan EndTime { get; set; }
   }
}
