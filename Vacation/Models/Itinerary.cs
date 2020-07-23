using System.Collections.Generic;
using Vacation.Models;

namespace Vacation.Models
{
  public class Itinerary
  {
    private static List<Itinerary> _instances = new List<Itinerary> {};
    public string Name { get; set; }
    public int Id { get; }
    public List<Trip> Destinations { get; set; }

    public Itinerary(string name)
    {
      Name = name;
      _instances.Add(this);
      Id = _instances.Count;
      Destinations = new List<Trip>{};
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Itinerary> GetAll()
    {
      return _instances;
    }  

    public static Itinerary Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public void AddTrip(Trip trip)
    {
      Destinations.Add(trip);
    }

  }
}
