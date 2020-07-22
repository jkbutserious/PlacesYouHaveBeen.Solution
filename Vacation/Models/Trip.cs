using System.Collections.Generic;

namespace Vacation.Models
{
  public class Trip
  {
    public string City {get; set;}
    public int Date { get; set; }
    public int Rating { get; set; }
    public int Id { get; }
    private static List<Trip> _trips = new List<Trip> {};

    public Trip(string city, int date, int rating)
    {
      City = city;
      Date = date;
      Rating = rating;
      _trips.Add(this);
      Id = _trips.Count;

    }

    // public bool WorthBuying(int maxPrice)
    // {
    //   return (Price < maxPrice);
    // }

    // public static string MakeSound(string sound)
    // {
    //   return "Our cars go " + sound;
    // }

    public static List<Trip> GetAll()
    {
      return _trips;
    }

    public static void ClearAll()
    {
      _trips.Clear();
    }

    public static Trip Find(int searchId)
    {
      return _trips[searchId -1 ];
    }
  }
}