 using System;
using System.Collections.Generic;
using System.Linq;
namespace DeviceLocator.Core
{
    /// <summary>
    /// Manager classes are an abstraction on the data access layers
    /// </summary>
    public  class DeviceLocatorManager
    {

        public  DeviceLocatorManager()
        {
           
        }

       /* private static readonly LatLng[] LocationForCustomIconMarkers = new[]
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
        "California"  ,     ,"Las Vegas","Salt Lake City","Denver" ,"Kansas City" ,"Chicago","New York", "Boston",                                                                               
                                                                            };*/
        public List<ParkingLocation> InitializeParkingLocations()
        {
            List<ParkingLocation> parkingLots = new List<ParkingLocation>();
            ParkingLocation p = new ParkingLocation (){                                                                                                                                                            
                Latitude = 37.0000,
                Longitude  =-120.0000,  
                AreaName = "California" ,                                

            };
            parkingLots.Add(p);
             p = new ParkingLocation (){ 
                                                                                                                                                         
                Latitude =34.0500,
                Longitude  =-118.2500,    
                AreaName =  "Los Angeles" 
            };
            parkingLots.Add(p);

             p = new ParkingLocation (){ 
                                                                                                                                                         
                Latitude =36.1215 ,
                Longitude  =  -115.1739 ,
                AreaName =  "Las Vegas"
               
            };
            parkingLots.Add(p);

             p = new ParkingLocation (){ 
                                                                                                                                                         
                Latitude =40.7500 ,
                Longitude  =  -111.8833  ,
                AreaName =  "Salt Lake City"            
            };
            parkingLots.Add(p);

             p = new ParkingLocation (){ 
                                                                                                                                                         
                Latitude =39.7392 ,
                Longitude  =  -104.9903 ,
                AreaName =  "Denver"           
            };
            parkingLots.Add(p);

              p = new ParkingLocation (){ 
                                                                                                                                                         
                Latitude =39.0997 ,
                Longitude  = - 94.5783 ,
                AreaName =  "Kansas City"          
            };
            parkingLots.Add(p);

               p = new ParkingLocation (){ 
                                                                                                                                                         
                Latitude =41.8369 ,
                Longitude  = -87.6847 ,
                AreaName =  "Chicago"                   
            };
            parkingLots.Add(p);
                p = new ParkingLocation (){ 
                                                                                                                                                         
                Latitude =40.7127,
                Longitude  = - 74.0059  ,
                AreaName = "New York"                  
            };
            parkingLots.Add(p);
              p = new ParkingLocation (){ 
                                                                                                                                                         
                Latitude = 42.3601, 
                Longitude  =  -71.0589     ,
                AreaName = "Boston"              
            };
            parkingLots.Add(p);
            RearrangeTimings(ref parkingLots);
            return parkingLots;

        }


        public List<ParkingLocation> InitializeParkingLocationsCalifornia()
        {
            List<ParkingLocation> parkingLots = new List<ParkingLocation>();
            ParkingLocation p = new ParkingLocation()
            {
                Latitude = 37.0000,
                Longitude = -120.0000,
                AreaName = "California",

            };
            parkingLots.Add(p);
            p = new ParkingLocation()
            {

                Latitude = 37.0010153,
                Longitude = -119.99989,
                AreaName = "ISland DRMadera"
            };
            parkingLots.Add(p);

            p = new ParkingLocation()
            {

                Latitude = 36.992005,
                Longitude = -119.8583772,
                AreaName = "Madera CA "

            };
            parkingLots.Add(p);

            p = new ParkingLocation()
            {

                Latitude = 37.251926,
                Longitude = -119.6962677,
                AreaName = "Madera Country "
            };
            parkingLots.Add(p);

            p = new ParkingLocation()
            {

                Latitude = 36.77826,
                Longitude = -119.4179324,
                AreaName = "California"
            };
            parkingLots.Add(p);

            p = new ParkingLocation()
            {

                Latitude = 37.09024,
                Longitude = -95.712891,
                AreaName = "no address "
            };
            parkingLots.Add(p);

            //p = new ParkingLocation()
            //{

            //    Latitude = 41.8369,
            //    Longitude = -87.6847,
            //    AreaName = "Chicago"
            //};
            //parkingLots.Add(p);
            //p = new ParkingLocation()
            //{

            //    Latitude = 40.7127,
            //    Longitude = -74.0059,
            //    AreaName = "New York"
            //};
            //parkingLots.Add(p);
            //p = new ParkingLocation()
            //{

            //    Latitude = 42.3601,
            //    Longitude = -71.0589,
            //    AreaName = "Boston"
            //};
            //parkingLots.Add(p);
            RearrangeTimings(ref parkingLots);
            return parkingLots;

        }

        public List<ParkingLocation> InitializeParkingLocationsLosAngels()
        {
            List<ParkingLocation> parkingLots = new List<ParkingLocation>();
            ParkingLocation p = new ParkingLocation()
            {
                Latitude = 34.0500339,
                Longitude = -118.249662,
                AreaName = "St los angles",

            };
            parkingLots.Add(p);
            p = new ParkingLocation()
            {

                Latitude = 34.0475897,
                Longitude = -118.250082,
                AreaName = "Hostoric Corelos Angeles"
            };
            parkingLots.Add(p);

            p = new ParkingLocation()
            {

                Latitude = 34.040713,
                Longitude = -118.2467693,
                AreaName = "downtown "

            };
            parkingLots.Add(p);

            //p = new ParkingLocation()
            //{

            //    Latitude = 34.0686748,
            //    Longitude = -118.3228165,
            //    AreaName = "central la los "
            //};
            //parkingLots.Add(p);

            //p = new ParkingLocation()
            //{

            //    Latitude = 34.0522342,
            //    Longitude = -118.2436849,
            //    AreaName = "los angeles"
            //};
            parkingLots.Add(p);

            p = new ParkingLocation()
            {

                Latitude = 34.043925,
                Longitude = -118.2424291,
                AreaName = "Los angeles"
            };
            parkingLots.Add(p);

            p = new ParkingLocation()
            {

                Latitude = 34.0522265,
                Longitude = -118.2436596,
                AreaName = "Los angeles country "
            };
            parkingLots.Add(p);
            //p = new ParkingLocation()
            //{

            //    Latitude = 36.77826,
            //    Longitude = -119.4179324,
            //    AreaName = "california "
            //};
            //parkingLots.Add(p);
            //p = new ParkingLocation()
            //{

            //    Latitude = 42.3601,
            //    Longitude = -71.0589,
            //    AreaName = "Boston"
            //};
            //parkingLots.Add(p);
            RearrangeTimings(ref parkingLots);
            return parkingLots;

        }


        public List<ParkingLocation> InitializeParkingLocationsParking()
        {
            List<ParkingLocation> parkingLots = new List<ParkingLocation>();

            ParkingLocation p = new ParkingLocation()
            {
                Latitude = 34.041252,
                Longitude = -118.256694,
                // AreaName = "940 S Main St",
                AreaName = "Slot9",

            };
            parkingLots.Add(p);
             p = new ParkingLocation()
            {
                Latitude = 34.041306,
                Longitude =  -118.256538,
               // AreaName = "940 S Broadway",
                AreaName = "Slot1",


            };
            parkingLots.Add(p);

                p = new ParkingLocation()
            {
                Latitude = 34.041162,
                Longitude = -118.256299,
                //  AreaName = "931 S Main St",
                AreaName = "Slot4",
            };
            parkingLots.Add(p);
            p = new ParkingLocation()
            {
                Latitude = 34.041324,
                Longitude = -118.256512,
                //  AreaName = "940 S Broadway",
                AreaName = "Slot2",
            };
            parkingLots.Add(p);
            p = new ParkingLocation()
            {
                Latitude = 34.041439,
                Longitude = -118.256329,
                //AreaName = "940 S Broadway",
                AreaName = "Slot3",

            };
            parkingLots.Add(p);


            p = new ParkingLocation()
            {
                Latitude = 34.041336,
                Longitude = -118.256220,
                // AreaName = "940 S Main St",
                AreaName = "Slot11",

            };
            parkingLots.Add(p);

            p = new ParkingLocation()
            {
                Latitude = 34.041182,
                Longitude = -118.255977,
                //  AreaName = "931 S Main St",
                AreaName = "Slot10",
            };
            parkingLots.Add(p);

           
         

            p = new ParkingLocation()
            {
                Latitude = 34.041025,
                Longitude = -118.256156,
                //  AreaName = "931 S Main St",
                AreaName = "Slot5",

            };
            parkingLots.Add(p);

            p = new ParkingLocation()
            {
                Latitude = 34.041029,
                Longitude = -118.256183,
                // AreaName = "937 S Main St",
                AreaName = "Slot6",

            };
            parkingLots.Add(p);

            p = new ParkingLocation()
            {
                Latitude =   34.040908,
                Longitude =  -118.256326,
                //  AreaName = "945 S Main St",
                AreaName = "Slot7",

            };
          
            parkingLots.Add(p);

            p = new ParkingLocation()
            {
                Latitude = 34.041057, 
                Longitude =-118.256517,
                // AreaName = "945 S Main St",
                AreaName = "Slot8",

            };
            parkingLots.Add(p);





            // p = new ParkingLocation()
            //{
            //    Latitude =  34.041336,
            //    Longitude =     -118.256220 ,
            //   // AreaName = "940 S Main St",
            //    AreaName = "Slot12",

            //};
            //parkingLots.Add(p);


        
 
           
            RearrangeTimings(ref parkingLots);
            return parkingLots;

        } 


        public void AssignTime( ref ParkingLocation parkingLot, double parkingCharges) 
        {
           parkingLot.StartTime = DateTime.Now;
           parkingLot.EndTime = CalculateEndTime( parkingLot.StartTime , parkingCharges) ;
           parkingLot.LastVisitTime = DateTime.Now ;
        }

        public DateTime CalculateEndTime ( DateTime startTime, double amountPaid)
        {
        DateTime endTime = DateTime.Now ;
            switch (amountPaid.ToString()) 
            {
                case "10" :
                    endTime = startTime.AddMinutes (5) ;
                    break;
                case "20" :
                    endTime = startTime.AddMinutes (10) ;
                    break;
                case "30" :
                    endTime = startTime.AddMinutes (15) ;
                    break;
                case "40" :
                    endTime = startTime.AddMinutes (20) ;
                    break;
                case "50" :
                    endTime = startTime.AddMinutes (30) ;
                    break;
                case "60" :
                    endTime = startTime.AddMinutes (45) ;
                    break;
                case "70" :
                    endTime = startTime.AddMinutes (60) ;
                    break;
                case "100" :
                    endTime = startTime.AddMinutes (120) ;
                    break;
                default :
                    endTime = startTime.AddMinutes (5) ;
                    break;
            }
        return endTime;

        }

        public void RearrangeTimings(ref List<ParkingLocation> parkingLots)
        {
            Random random = new Random();
            List<int> indices = RandomiseData(parkingLots.Count);

            //List<int> indices = new List<int>() {7,0, 2,5,6,4,1,3,8};

            for (int i = 0; i < indices.Count; i++)
            {

                ParkingLocation parkLocation = parkingLots[indices[i]];
                parkLocation.StartTime = DateTime.Now;
                if (indices[i] == 1 || indices[i] == 3 || indices[i] % 5 == 0)
                {
                    parkLocation.AmountPaid = 30;

                }
                else if (indices[i] == 2 || indices[i] == 5 || indices[i] == 7 || indices[i] % 2 == 0)
                {
                    parkLocation.AmountPaid = 20;
                }
                else if (indices[i] == 4 || indices[i] == 8 || indices[i] % 3 == 0)
                {
                    parkLocation.AmountPaid = 50;
                }
                else
                {
                    parkLocation.AmountPaid = 10;
                }
                parkLocation.EndTime = CalculateEndTime(parkLocation.StartTime, parkLocation.AmountPaid);
            }



        }


        private List<int> RandomiseData(int maxLength)
        {

            List<int> numbers = new List<int>();
            for (int i = 0; i < maxLength; i++)
            {
                numbers.Add(i);
            }
         //   return numbers;
            var random = new Random();
            List<int> randomized = numbers.OrderBy(x => random.Next()).ToList();
            return randomized;
        }



    }
}