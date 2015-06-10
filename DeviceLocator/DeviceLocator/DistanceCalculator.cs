using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceLocator.Core
{
   public class DistanceCalculator
    {

     static  List<SlotDistance> slotDistances = new List<SlotDistance> () ;
      static List<ParkingLocation> slots = new List<ParkingLocation> (); 
       
       public static List<ParkingLocation> InitializeSlots()
       {
            slots = new List<ParkingLocation>();
           ParkingLocation slot = new ParkingLocation()
            {
                Id = 1,
                Latitude = 34.042598,
                Longitude = -118.254496,   
                AdjustantSlots = new List<int>() { 2, 10 }

            };
           slot.AreaName = "Slot" + slot.Id.ToString();
           slots.Add(slot);
           slot = new ParkingLocation()
           {
               Id = 2,
               Latitude = 34.042604,
               Longitude = -118.254467,
               AdjustantSlots = new List<int>() { 1, 3, 11 }
           };
           slot.AreaName = "Slot" + slot.Id.ToString();
           slots.Add(slot);
           slot = new ParkingLocation()
           {
               Id = 3,
               Latitude = 34.042623,
               Longitude = -118.254455,
               AdjustantSlots = new List<int>() { 2, 4, 12 }
           };
           slot.AreaName = "Slot" + slot.Id.ToString();
           slots.Add(slot);
           slot = new ParkingLocation()
           {
               Id = 4,
               Latitude = 34.042636,
               Longitude = -118.254430,
               AdjustantSlots = new List<int>() { 3, 5, 13 }
           };
           slot.AreaName = "Slot" + slot.Id.ToString();
           slots.Add(slot);
           slot = new ParkingLocation()
           {
               Id = 5,
               Latitude = 34.042655,
               Longitude = -118.254408,
               AdjustantSlots = new List<int>() { 4, 6, 14 }
           };
           slot.AreaName = "Slot" + slot.Id.ToString();
           slots.Add(slot);
           slot = new ParkingLocation()
           {
               Id = 6,
               Latitude = 34.042669,
               Longitude = -118.254402,
               AdjustantSlots = new List<int>() { 5, 7, 15 }
           };
           slot.AreaName = "Slot" + slot.Id.ToString();
           slots.Add(slot);
           slot = new ParkingLocation()
           {
               Id = 7,
               Latitude = 34.042687,
               Longitude = -118.254381,
               AdjustantSlots = new List<int>() { 6, 8, 16 }
           };
           slot.AreaName = "Slot" + slot.Id.ToString();
           slots.Add(slot);
           slot = new ParkingLocation()
           {
               Id = 8,
               Latitude = 34.042703,
               Longitude = -118.254370,
               AdjustantSlots = new List<int>() { 7, 9, 17 }
           };
           slot.AreaName = "Slot" + slot.Id.ToString();
           slots.Add(slot);
           slot = new ParkingLocation()
           {
               Id = 9,
               Latitude = 34.042716,
               Longitude = -118.254347,
               AdjustantSlots = new List<int>() { 8, 18 }
           };
           slot.AreaName = "Slot" + slot.Id.ToString();
           slots.Add(slot);
           slot = new ParkingLocation()
           {
               Id = 10,
               Latitude = 34.042618,
               Longitude = -118.254533,
               AdjustantSlots = new List<int>() { 1, 19, 11 }
           };
           slot.AreaName = "Slot" + slot.Id.ToString();
           slots.Add(slot);
           slot = new ParkingLocation()
           {
               Id = 11,
               Latitude = 34.042629,
               Longitude = -118.254521,
               AdjustantSlots = new List<int>() { 2, 10, 20, 12 }
           };
           slot.AreaName = "Slot" + slot.Id.ToString();
           slots.Add(slot);
           slot = new ParkingLocation()
           {
               Id = 12,
               Latitude = 34.042654,
               Longitude = -118.254501,
               AdjustantSlots = new List<int>() { 3, 11, 21, 13 }
           };
           slot.AreaName = "Slot" + slot.Id.ToString();
           slots.Add(slot);
           slot = new ParkingLocation()
           {
               Id = 13,
               Latitude = 34.042670,
               Longitude = -118.254481,
               AdjustantSlots = new List<int>() { 4, 12, 22, 14 }
           };
           slot.AreaName = "Slot" + slot.Id.ToString();
           slots.Add(slot);
           slot = new ParkingLocation()
           {
               Id = 14,
               Latitude = 34.042687,
               Longitude = -118.254474,
               AdjustantSlots = new List<int>() { 5, 13, 23, 15 }
           };
           slot.AreaName = "Slot" + slot.Id.ToString();
           slots.Add(slot);
           slot = new ParkingLocation()
           {
               Id = 15,
               Latitude = 34.042709,
               Longitude = -118.254449,
               AdjustantSlots = new List<int>() { 6, 14, 24, 16 }
           };
           slot.AreaName = "Slot" + slot.Id.ToString();
           slots.Add(slot);
           slot = new ParkingLocation()
           {
               Id = 16,
               Latitude = 34.042720,
               Longitude = -118.254426,
               AdjustantSlots = new List<int>() { 7, 15, 25, 17 }
           };
           slot.AreaName = "Slot" + slot.Id.ToString();
           slots.Add(slot);
           slot = new ParkingLocation()
           {
               Id = 17,
               Latitude = 34.042742,
               Longitude = -118.254413,
               AdjustantSlots = new List<int>() { 8, 16, 26, 18 }
           };
           slot.AreaName = "Slot" + slot.Id.ToString();
           slots.Add(slot);
           slot = new ParkingLocation()
           {
               Id = 18,
               Latitude = 34.042753,
               Longitude = -118.254404,
               AdjustantSlots = new List<int>() { 9, 17, 27 }
           };
           slot.AreaName = "Slot" + slot.Id.ToString();
           slots.Add(slot);
           slot = new ParkingLocation()
           {
               Id = 19,
               Latitude = 34.042640,
               Longitude = -118.254577,
               AdjustantSlots = new List<int>() { 10, 20 }
           };
           slot.AreaName = "Slot" + slot.Id.ToString();
           slots.Add(slot);
           slot = new ParkingLocation()
           {
               Id = 20,
               Latitude = 34.042665,
               Longitude = -118.254560,
               AdjustantSlots = new List<int>() { 11, 19, 21 }
           };
           slot.AreaName = "Slot" + slot.Id.ToString();
           slots.Add(slot);
           slot = new ParkingLocation()
           {
               Id = 21,
               Latitude = 34.042679,
               Longitude = -118.254542,
               AdjustantSlots = new List<int>() { 12, 20, 22 }
           };
           slot.AreaName = "Slot" + slot.Id.ToString();
           slots.Add(slot);
           slot = new ParkingLocation()
           {
               Id = 22,
               Latitude = 34.042694,
               Longitude = -118.254516,
               AdjustantSlots = new List<int>() { 13, 21, 23 }
           };
           slot.AreaName = "Slot" + slot.Id.ToString();
           slots.Add(slot);
           slot = new ParkingLocation()
           {
               Id = 23,
               Latitude = 34.042710,
               Longitude = -118.254505,
               AdjustantSlots = new List<int>() { 14, 22, 24 }
           };
           slot.AreaName = "Slot" + slot.Id.ToString();
           slots.Add(slot);
           slot = new ParkingLocation()
           {
               Id = 24,
               Latitude = 34.042727,
               Longitude = -118.254488,
               AdjustantSlots = new List<int>() { 15, 23, 25 }
           };
           slot.AreaName = "Slot" + slot.Id.ToString();
           slots.Add(slot);
           slot = new ParkingLocation()
           {
               Id = 25,
               Latitude = 34.042742,
               Longitude = -118.254476,
               AdjustantSlots = new List<int>() { 16, 24, 26 }
           };
           slot.AreaName = "Slot" + slot.Id.ToString();
           slots.Add(slot);
           slot = new ParkingLocation()
           {
               Id = 26,
               Latitude = 34.042710,
               Longitude = -118.254505,
               AdjustantSlots = new List<int>() { 17, 25, 27 }
           };
           slot.AreaName = "Slot" + slot.Id.ToString();
           slots.Add(slot);
           slot = new ParkingLocation()
           {
               Id = 27,
               Latitude = 34.042710,
               Longitude = -118.254505,
               AdjustantSlots = new List<int>() { 18, 26 }
           };
           slot.AreaName = "Slot" + slot.Id.ToString();
           slots.Add(slot);
           CalculateDistancesAdjustantPoints(slots);
           DeviceLocatorManager d = new DeviceLocatorManager();
           d.RearrangeTimings(ref slots); 

           return slots;
       }

       public static List<SlotDistance> CalculateDistancesAdjustantPoints(List<ParkingLocation> slots)
       {
           slotDistances = new List<SlotDistance>();
           foreach (ParkingLocation slot in slots)
           {
               SlotDistance slotDistance1 = new SlotDistance();
               slotDistance1.StartSlot = slot.Id;
               slotDistance1.DestinationSlot = slot.Id;
               slotDistance1.Distance = 0;
               slotDistance1.ViaPoints = new List<int>() { slot.Id };
               slotDistances.Add(slotDistance1);

               foreach (int i in slot.AdjustantSlots)              {

                    
                   ParkingLocation adjustancLocation = slots.FirstOrDefault(x => x.Id == i);

                   SlotDistance slotDistance = new SlotDistance();
                   slotDistance.StartSlot = slot.Id;
                   slotDistance.DestinationSlot = adjustancLocation.Id;
                   slotDistance.Distance = Distance(slot.Latitude, slot.Longitude, adjustancLocation.Latitude, adjustancLocation.Longitude, 'N');
                   slotDistance.ViaPoints = new List<int>() { slot.Id, adjustancLocation.Id };
                   slotDistances.Add(slotDistance);
               }

           }

           for (int i = 0; i < slots.Count; i++)
           {
               ParkingLocation node = (ParkingLocation) slots[i];
               for (int j = 0; j < slots.Count; j++)
               {
                   ParkingLocation targetNode = (ParkingLocation) slots[j];
                              var distance = slotDistances.AsEnumerable().Where(m => m.StartSlot == node.Id && m.DestinationSlot == targetNode.Id)  ;
          
           SlotDistance dis = distance.FirstOrDefault();
           if ( dis == null )
           {
               List<ParkingLocation> path = FindShortestPath(node, targetNode);
               if (path != null)
               {
                   AddDisjointSlots(path);
               }
           }
               }
            }


               return slotDistances;
       }

       public static void AddDisjointSlots(List<ParkingLocation> path )
       {
           SlotDistance slotDistance = new SlotDistance();
           slotDistance.StartSlot = path.First().Id;
           slotDistance.DestinationSlot = path.Last().Id;
           slotDistance.ViaPoints = new List<int>();
           double distanceTravelled = 0;
           for (int i = 0; i < path.Count - 1; i++)
           {
               ParkingLocation p1 = path[i];
               ParkingLocation p2 = path[i + 1];
               distanceTravelled = distanceTravelled + DistanceCalculator.FindDistance(p1, p2);
               slotDistance.ViaPoints.Add(p1.Id);
           }
           slotDistance.ViaPoints.Add(path.Last().Id);
           slotDistance.Distance = distanceTravelled;
            slotDistances.Add( slotDistance);
       }
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



       public static List<ParkingLocation> FindShortestPath(ParkingLocation sourceNode, ParkingLocation destinationNode)
       {
           //find path from source-node to destination-node
           List<ParkingLocation> path = new List<ParkingLocation>();
           path.Add(sourceNode);
           List<ParkingLocation> visitedNodes = new List<ParkingLocation> ();
           ParkingLocation currentNode = sourceNode;
           while (true)
           {
               //get all neighbors of current-node (nodes within transmission range)
               List<ParkingLocation> allNeighbors = GetNeighbors(currentNode, slots);

               //avoid duplicate nodes in path
               IEnumerable<ParkingLocation> neighbors = from neighbor in allNeighbors
                                             where !path.Contains(neighbor)
                                             select neighbor;

               //stop if no neighbors or destination reached
               if (neighbors.Count() == 0) break;
               if (neighbors.Contains(destinationNode))
               {
                   path.Add(destinationNode);
                   break;
               }

               //choose next-node (the neighbor with shortest distance to destination)
               ParkingLocation nearestNode = FindNearestNode(neighbors, destinationNode, ref visitedNodes);
               path.Add(nearestNode);
               currentNode = nearestNode;
           }

           return (path);
       }

       public static ParkingLocation FindNearestNode(IEnumerable<ParkingLocation> nodes, ParkingLocation targetNode, ref List<ParkingLocation>  visitedNodes)
       {
           double shortestDistance = -1;
           ParkingLocation nearestNode = null;

           int index = 0;
           foreach (ParkingLocation node in nodes)
           {
               if ( ! visitedNodes.Contains(node))
               visitedNodes.Add(node);
               double distance = FindDistance(node, targetNode);
               if (index == 0)
               {
                   shortestDistance = distance;
                   nearestNode = node;
               }
               else if (shortestDistance > distance)
               {
                   shortestDistance = distance;
                   nearestNode = node;
               }
               index += 1;
           }

           return (nearestNode);
       }

       public static  double FindDistance(ParkingLocation node, ParkingLocation targetNode)
       {
           var distance = slotDistances.AsEnumerable().Where(m => m.StartSlot == node.Id && m.DestinationSlot == targetNode.Id)  ;
          
           SlotDistance dis = distance.FirstOrDefault();
           if ( dis != null )
           return dis.Distance;
           else 
           {
               return Distance(node.Latitude, node.Longitude, targetNode.Latitude, targetNode.Longitude, 'N');
           }
         
       }

 

       public static List<ParkingLocation> GetNeighbors(ParkingLocation currentSlot, List<ParkingLocation> slots)
       {
           var parkLot = from s in slots 
                         where currentSlot.AdjustantSlots.Contains(s.Id)  
                         select s;

           return parkLot.ToList();
       }

       //public static List<ParkingLocation> GetPath(ParkingLocation sourceNode, List<ParkingLocation> slots)
       //{
       //    List<ParkingLocation> path = new List<ParkingLocation>();
       //    List<ParkingLocation> visitedNodes = new List<ParkingLocation>();

       //    List<ParkingLocation> neighbour = GetNeighbors(sourceNode, slots);
       //    ParkingLocation nearest = FindNearestNode(neighbour, sourceNode, ref visitedNodes);
       //    if (nearest.RemainingTime.Minutes < 20)
       //    {
       //        path.Add(nearest);
       //    } 
       //    GetPath ()




       //    return path; 

       
       //}


    }
}
