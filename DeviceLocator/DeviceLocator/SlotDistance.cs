using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceLocator.Core
{
    public class SlotDistance
    {
        public int StartSlot { get; set; }
        public int DestinationSlot { get; set; }
        public double Distance { get; set; }
        public List<int> ViaPoints { get; set; }
    }
}
