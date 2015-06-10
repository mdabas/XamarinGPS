using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeviceLocator.Core
{
    public class ParkingLocation
    {
        public int Id { get; set; }
        public float AmountPaid { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime LastVisitTime { get; set; } 
        public double Latitude {get;set;} 
        public double Longitude {get;set;}
        public string AreaName { get; set; }
        public TimeSpan RemainingTime
        {
            get
            {
                return EndTime - StartTime;
            }
        }

        public List<int> AdjustantSlots { get; set; }
    }
}
