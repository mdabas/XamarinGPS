using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMapApp
{
    public static class MarkerPointBusinessMethods
    {
        #region Initialization Methods and properties

        static List<MarkerPoint> markerPoints = new List<MarkerPoint>();
        static List<MarkerPointAlog> markerPointAlgo = new List<MarkerPointAlog>();
        public static List<MarkerPoint> InitializemarkerPoints()
        {
            //List<GeoCoordinate> cinemaLocations = new List<GeoCoordinate>();
            //GeoCoordinate myLocation = new GeoCoordinate();
            //var closestCinemas = cinemaLocations.OrderBy(s => s.GetDistanceTo(myLocation));
            //var closestCinema = closestCinemas.FirstOrDefault();
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
                StartTime = new TimeSpan(1, 20, 0),
                EndTime = new TimeSpan(1, 23, 0)
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
        public static List<MarkerPointAlog> InitializeMarkerPointAlgo()
        {
            //List<GeoCoordinate> cinemaLocations = new List<GeoCoordinate>();
            //GeoCoordinate myLocation = new GeoCoordinate();
            //var closestCinemas = cinemaLocations.OrderBy(s => s.GetDistanceTo(myLocation));
            //var closestCinema = closestCinemas.FirstOrDefault();
            markerPointAlgo = new List<MarkerPointAlog>();


            MarkerPointAlog p = new MarkerPointAlog()
            {
                Id = 1,
                AdjustantTopSlots = null,
                AdjustantRightSlots = null,
                AdjustantBottomSlots = new List<int> { 2, 3 },
                AdjustantLeftSlots = new List<int> { 16, 15, 14 },
                Latitude = 34.050722,
                Longitude = -118.251470,
                StartTime = new TimeSpan(1, 20, 0),
                EndTime = new TimeSpan(1, 23, 0)
            };
            markerPointAlgo.Add(p);

            p = new MarkerPointAlog()
           {
               Id = 2,
               AdjustantTopSlots = new List<int> { 1 },
               AdjustantRightSlots = null,
               AdjustantBottomSlots = new List<int> { 3 },
               AdjustantLeftSlots = null,
               Latitude = 34.050518,
               Longitude = -118.251164,
               StartTime = new TimeSpan(1, 20, 0),
               EndTime = new TimeSpan(1, 28, 0)
           };
            markerPointAlgo.Add(p);

            p = new MarkerPointAlog()
            {
                Id = 3,
                AdjustantTopSlots = new List<int> { 1, 2 },
                AdjustantRightSlots = null,
                AdjustantBottomSlots = new List<int> { 4, 5, 6 },
                AdjustantLeftSlots = null,
                Latitude = 34.050282,
                Longitude = -118.250778,
                StartTime = new TimeSpan(1, 20, 0),
                EndTime = new TimeSpan(1, 26, 0)
            };
            markerPointAlgo.Add(p);

            p = new MarkerPointAlog()
            {
                Id = 4,
                AdjustantTopSlots = new List<int> { 3 },
                AdjustantRightSlots = null,
                AdjustantBottomSlots = new List<int> { 5, 6 },
                AdjustantLeftSlots = null,
                Latitude = 34.050038,
                Longitude = -118.250381,
                StartTime = new TimeSpan(1, 20, 0),
                EndTime = new TimeSpan(1, 35, 0)
            };
            markerPointAlgo.Add(p);

            p = new MarkerPointAlog()
            {
                Id = 5,
                AdjustantTopSlots = new List<int> { 4 },
                AdjustantRightSlots = null,
                AdjustantBottomSlots = new List<int> { 6 },
                AdjustantLeftSlots = null,
                Latitude = 34.049833,
                Longitude = -118.250123,
                StartTime = new TimeSpan(1, 20, 0),
                EndTime = new TimeSpan(1, 23, 0)
            };
            markerPointAlgo.Add(p);

            p = new MarkerPointAlog()
            {
                Id = 6,
                AdjustantTopSlots = new List<int> { 5, 4 },
                AdjustantRightSlots = new List<int> { 7, 8, 9 },
                AdjustantBottomSlots = null,
                AdjustantLeftSlots = null,
                Latitude = 34.049562,
                Longitude = -118.249721,
                StartTime = new TimeSpan(1, 20, 0),
                EndTime = new TimeSpan(1, 28, 0)
            };
            markerPointAlgo.Add(p);

            p = new MarkerPointAlog()
            {
                Id = 7,
                AdjustantTopSlots = null,
                AdjustantRightSlots = new List<int> { 8, 9 },
                AdjustantBottomSlots = null,
                AdjustantLeftSlots = new List<int> { 6 },
                Latitude = 34.049176,
                Longitude = -118.249968,
                StartTime = new TimeSpan(1, 20, 0),
                EndTime = new TimeSpan(1, 40, 0)
            };
            markerPointAlgo.Add(p);

            p = new MarkerPointAlog()
            {
                Id = 8,
                AdjustantTopSlots = null,
                AdjustantRightSlots = new List<int> { 9 },
                AdjustantBottomSlots = null,
                AdjustantLeftSlots = new List<int> { 7 },
                Latitude = 34.048829,
                Longitude = -118.250241,
                StartTime = new TimeSpan(1, 20, 0),
                EndTime = new TimeSpan(1, 23, 0)
            };
            markerPointAlgo.Add(p);

            p = new MarkerPointAlog()
            {
                Id = 9,
                AdjustantTopSlots = new List<int> { 10, 11, 12 },
                AdjustantRightSlots = null,
                AdjustantBottomSlots = null,
                AdjustantLeftSlots = new List<int> { 8, 7 },
                Latitude = 34.048344,
                Longitude = -118.250660,
                StartTime = new TimeSpan(1, 20, 0),
                EndTime = new TimeSpan(1, 35, 0)
            };
            markerPointAlgo.Add(p);

            p = new MarkerPointAlog()
            {
                Id = 10,
                AdjustantTopSlots = new List<int> { 11, 12 },
                AdjustantRightSlots = new List<int> { 9 },
                AdjustantBottomSlots = null,
                AdjustantLeftSlots = null,
                Latitude = 34.048469,
                Longitude = -118.251180,
                StartTime = new TimeSpan(1, 20, 0),
                EndTime = new TimeSpan(1, 28, 0)
            };
            markerPointAlgo.Add(p);

            p = new MarkerPointAlog()
            {
                Id = 11,
                AdjustantTopSlots = new List<int> { 12 },
                AdjustantRightSlots = null,
                AdjustantBottomSlots = new List<int> { 10 },
                AdjustantLeftSlots = null,
                Latitude = 34.048740,
                Longitude = -118.251620,
                StartTime = new TimeSpan(1, 20, 0),
                EndTime = new TimeSpan(1, 23, 0)
            };
            markerPointAlgo.Add(p);

            p = new MarkerPointAlog()
            {
                Id = 12,
                AdjustantTopSlots = new List<int> { 13 },
                AdjustantRightSlots = null,
                AdjustantBottomSlots = new List<int> { 11 },
                AdjustantLeftSlots = null,
                Latitude = 34.049051,
                Longitude = -118.252060,
                StartTime = new TimeSpan(1, 20, 0),
                EndTime = new TimeSpan(1, 47, 0)
            };
            markerPointAlgo.Add(p);

            p = new MarkerPointAlog()
            {
                Id = 13,
                AdjustantTopSlots = null,
                AdjustantRightSlots = new List<int> { 14, 15, 16 },
                AdjustantBottomSlots = new List<int> { 12, 11 },
                AdjustantLeftSlots = null,
                Latitude = 34.049433,
                Longitude = -118.252623,
                StartTime = new TimeSpan(1, 20, 0),
                EndTime = new TimeSpan(1, 23, 0)
            };
            markerPointAlgo.Add(p);

            p = new MarkerPointAlog()
            {
                Id = 14,
                AdjustantTopSlots = null,
                AdjustantRightSlots = new List<int> { 15, 16 },
                AdjustantBottomSlots = null,
                AdjustantLeftSlots = new List<int> { 13 },
                Latitude = 34.049704,
                Longitude = -118.252543,
                StartTime = new TimeSpan(1, 20, 0),
                EndTime = new TimeSpan(1, 29, 0)

            };
            markerPointAlgo.Add(p);

            p = new MarkerPointAlog()
            {
                Id = 15,
                AdjustantTopSlots = null,
                AdjustantRightSlots = new List<int> { 16 },
                AdjustantBottomSlots = null,
                AdjustantLeftSlots = new List<int> { 14, 13 },
                Latitude = 34.050072,
                Longitude = -118.252186,
                StartTime = new TimeSpan(1, 20, 0),
                EndTime = new TimeSpan(1, 32, 0)
            };
            markerPointAlgo.Add(p);

            p = new MarkerPointAlog()
            {
                Id = 16,
                AdjustantTopSlots = null,
                AdjustantRightSlots = null,
                AdjustantBottomSlots = new List<int> { 1, 2, 3 },
                AdjustantLeftSlots = new List<int> { 15, 14 },
                Latitude = 34.050472,
                Longitude = -118.251827,
                StartTime = new TimeSpan(1, 20, 0),
                EndTime = new TimeSpan(1, 23, 0)
            };
            markerPointAlgo.Add(p);
            // markerPoints.Add(p);
            //RearrangeTimings(ref markerPoints);
            return markerPointAlgo;
            //markerPoints.Add(slot);
            //CalculateDistancesAdjustantPoints(markerPoints);
            //DeviceLocatorManager d = new DeviceLocatorManager();
            //d.RearrangeTimings(ref markerPoints);

            //return markerPoints;
        }

        #endregion

        #region Shortest Distance Methods

        public static List<MarkerPointAlog> GetMarkersForRoutePath(double srcLatitude, double srcLongitude, double destLatitude, double destLongitude)
        {
            int _destinationSlot = markerPointAlgo.Where(p => p.Latitude == destLatitude && p.Longitude == destLongitude).Select(p => p.Id).FirstOrDefault();
            List<MarkerPointAlog> _sortedList = markerPointAlgo.OrderBy(p => Distance(p.Latitude, p.Longitude, srcLatitude, srcLongitude, 'N')).OrderBy(p => p.IsRedMarked).ToList();
            return GetAllPossiblePaths(_sortedList[0], _destinationSlot);
        }

        public static List<MarkerPointAlog> GetAllPossiblePaths(MarkerPointAlog _firstPoint, int destSlot)
        {
            GetPathForFirstSlot(_firstPoint, destSlot);
            return GetShortestDistanceWithMaxRedMarkers();
        }

        public static List<MarkerPointAlog> GetShortestDistanceWithMaxRedMarkers()
        {
            List<SlotInformation> slotInformation = new List<SlotInformation>();
            int _totalPaths = pathArray.Count;
            foreach (var path in pathArray)
            {
                string[] slots = path.Split(',');
                int count = markerPointAlgo.Where(p => slots.Contains(p.Id.ToString()) && p.IsRedMarked).Count();
                slotInformation.Add(new SlotInformation { Distance = 0, RedMarkerCount = count, Slots = slots });
            }
            var shortestPath = slotInformation.OrderByDescending(p => p.RedMarkerCount).FirstOrDefault();
            return markerPointAlgo.Where(p => shortestPath.Slots.Contains(p.Id.ToString()) && p.IsRedMarked).ToList();
        }

        #endregion

        #region Path Routing Methods

        public static List<string> pathArray = new List<string>();
        public static string CreatedPath = "";
        public static void GetPathForFirstSlot(MarkerPointAlog _slot, int destSlot)
        {

            //var slotsArrived = arrivedSlots.ToArray();
            int i = 0;
            if (_slot.AdjustantBottomSlots != null)
            {
                int[] _slotsArray = _slot.AdjustantBottomSlots.ToArray();
                pathArray.Add(_slot.Id.ToString());
                pathArray[i] = pathArray[i] + "," + _slotsArray.Last().ToString();
                GetBetweenPaths(markerPointAlgo.Where(p => p.Id == _slotsArray.Last()).FirstOrDefault(), destSlot, pathArray[i]);
                string[] list = CreatedPath.Split(',');
                string firstElement = list[0];

                list = list.Skip(1).ToArray();
                string routePath = firstElement;
                foreach (var x in list)
                {
                    if (x != firstElement)
                    {

                        routePath = routePath == "" ? x : routePath + "," + x;

                    }
                    else
                    {
                        break;
                    }
                }
                pathArray[i] = routePath;
                i++;
            }
            if (_slot.AdjustantLeftSlots != null)
            {
                CreatedPath = "";
                int[] _slotsArray = _slot.AdjustantLeftSlots.ToArray();
                pathArray.Add(_slot.Id.ToString());
                pathArray[i] = pathArray[i] + "," + _slotsArray.Last().ToString();
                GetBetweenPaths(markerPointAlgo.Where(p => p.Id == _slotsArray.Last()).FirstOrDefault(), destSlot, pathArray[i]);
                string[] list = CreatedPath.Split(',');
                string firstElement = list[0];

                list = list.Skip(1).ToArray();
                string routePath = firstElement;
                foreach (var x in list)
                {
                    if (x != firstElement)
                    {

                        routePath = routePath == "" ? x : routePath + "," + x;

                    }
                    else
                    {
                        break;
                    }
                }
                pathArray[i] = routePath;
                i++;

            }
            if (_slot.AdjustantRightSlots != null)
            {
                CreatedPath = "";
                int[] _slotsArray = _slot.AdjustantRightSlots.ToArray();
                pathArray.Add(_slot.Id.ToString());
                pathArray[i] = pathArray[i] + "," + _slotsArray.Last().ToString();
                GetBetweenPaths(markerPointAlgo.Where(p => p.Id == _slotsArray.Last()).FirstOrDefault(), destSlot, pathArray[i]);
                string[] list = CreatedPath.Split(',');
                string firstElement = list[0];

                list = list.Skip(1).ToArray();
                string routePath = firstElement;
                foreach (var x in list)
                {
                    if (x != firstElement)
                    {

                        routePath = routePath == "" ? x : routePath + "," + x;

                    }
                    else
                    {
                        break;
                    }
                }
                pathArray[i] = routePath;
                i++;

            }
            if (_slot.AdjustantTopSlots != null)
            {
                CreatedPath = "";
                int[] _slotsArray = _slot.AdjustantTopSlots.ToArray();
                pathArray.Add(_slot.Id.ToString());
                pathArray[i] = pathArray[i] + "," + _slotsArray.Last().ToString();
                GetBetweenPaths(markerPointAlgo.Where(p => p.Id == _slotsArray.Last()).FirstOrDefault(), destSlot, pathArray[i]);
                string[] list = CreatedPath.Split(',');
                string firstElement = list[0];

                list = list.Skip(1).ToArray();
                string routePath = firstElement;
                foreach (var x in list)
                {
                    if (x != firstElement)
                    {

                        routePath = routePath == "" ? x : routePath + "," + x;

                    }
                    else
                    {
                        break;
                    }
                }
                pathArray[i] = routePath;

            }

        }
        public static void GetBetweenPaths(MarkerPointAlog _slot, int destSlot, string array)
        {

            if (_slot.AdjustantBottomSlots != null)
            {
                bool _isContinue = true;
                int[] _slotsArray = _slot.AdjustantBottomSlots.ToArray();
                foreach (int x in _slotsArray)
                {
                    string[] list = array.Split(',');
                    if (list.Contains(x.ToString()))
                    {
                        _isContinue = false;
                    }
                }
                if (_isContinue)
                {
                    foreach (int x in _slotsArray)
                    {
                        if (x == destSlot)
                        {
                            array = array + "," + x.ToString();
                            _isContinue = false;
                            break;
                        }
                        array = array + "," + x.ToString();
                    }
                }
                if (_isContinue)
                    GetBetweenPaths(markerPointAlgo.Where(p => p.Id == _slotsArray.Last()).FirstOrDefault(), destSlot, array);
            }
            if (_slot.AdjustantLeftSlots != null)
            {
                bool _isContinue = true;
                int[] _slotsArray = _slot.AdjustantLeftSlots.ToArray();
                foreach (int x in _slotsArray)
                {
                    string[] list = array.Split(',');
                    if (list.Contains(x.ToString()))
                    {
                        _isContinue = false;
                    }
                }
                if (_isContinue)
                {
                    foreach (int x in _slotsArray)
                    {
                        if (x == destSlot)
                        {
                            array = array + "," + x.ToString();
                            _isContinue = false;
                            break;
                        }
                        array = array + "," + x.ToString();
                    }
                }
                if (_isContinue)
                    GetBetweenPaths(markerPointAlgo.Where(p => p.Id == _slotsArray.Last()).FirstOrDefault(), destSlot, array);

            }
            if (_slot.AdjustantRightSlots != null)
            {
                bool _isContinue = true;
                int[] _slotsArray = _slot.AdjustantRightSlots.ToArray();
                foreach (int x in _slotsArray)
                {
                    string[] list = array.Split(',');
                    if (list.Contains(x.ToString()))
                    {
                        _isContinue = false;
                    }
                }
                if (_isContinue)
                {
                    foreach (int x in _slotsArray)
                    {
                        if (x == destSlot)
                        {
                            array = array + "," + x.ToString();
                            _isContinue = false;
                            break;
                        }
                        array = array + "," + x.ToString();
                    }
                }
                if (_isContinue)
                    GetBetweenPaths(markerPointAlgo.Where(p => p.Id == _slotsArray.Last()).FirstOrDefault(), destSlot, array);

            }
            if (_slot.AdjustantTopSlots != null)
            {
                bool _isContinue = true;
                int[] _slotsArray = _slot.AdjustantTopSlots.ToArray();
                foreach (int x in _slotsArray)
                {
                    string[] list = array.Split(',');
                    if (list.Contains(x.ToString()))
                    {
                        _isContinue = false;
                    }
                }
                if (_isContinue)
                {
                    foreach (int x in _slotsArray)
                    {
                        if (x == destSlot)
                        {
                            array = array + "," + x.ToString();
                            _isContinue = false;
                            break;
                        }
                        array = array + "," + x.ToString();
                    }
                }
                if (_isContinue)
                    GetBetweenPaths(markerPointAlgo.Where(p => p.Id == _slotsArray.Last()).FirstOrDefault(), destSlot, array);

            }

            CreatedPath = CreatedPath == "" ? array : CreatedPath + "," + array;

        }

        #endregion

        #region Distance converter methods
        public static double Distance(double lat1, double lon1, double lat2, double lon2, char unit)
        {

            double theta = lon1 - lon2;

            double dist = Math.Sin(deg2rad(lat1)) * Math.Sin(deg2rad(lat2)) + Math.Cos(deg2rad(lat1)) * Math.Cos(deg2rad(lat2)) * Math.Cos(deg2rad(theta));
            dist = Math.Acos(dist);
            dist = rad2deg(dist);
            dist = dist * 60 * 1.1515;
            if (unit == 'K')
            {
                dist = dist * 1.609344;
            }
            else if (unit == 'N')
            {
                dist = dist * 0.8684;
            }
            return (dist);
        }
        public static double deg2rad(double deg)
        {
            return (deg * Math.PI / 180.0);
        }
        public static double rad2deg(double rad)
        {
            return (rad / Math.PI * 180.0);

        }
        #endregion
    }

    #region Classes for Markers

    public class MarkerPoint
    {
        public int Id { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string AreaName { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }

    public class MarkerPointAlog
    {
        public int Id { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public List<int> AdjustantTopSlots { get; set; }
        public List<int> AdjustantBottomSlots { get; set; }
        public List<int> AdjustantLeftSlots { get; set; }
        public List<int> AdjustantRightSlots { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public bool IsRedMarked
        {
            get { return ((EndTime - StartTime).Minutes <= 5) ? true : false; }
        }
        public bool IsOrangeMarked
        {
            get { return (((EndTime - StartTime).Minutes > 5) && ((EndTime - StartTime).Minutes <= 10)) ? true : false; }
        }
        public bool IsGreenMarked
        {
            get { return ((EndTime - StartTime).Minutes > 10) ? true : false; }
        }
    }

    public class SlotInformation
    {
        public string[] Slots { get; set; }
        public double Distance { get; set; }
        public int RedMarkerCount { get; set; }
    }


    #endregion
}
