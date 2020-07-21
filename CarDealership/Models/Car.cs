using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    public string MakeModel {get; set;}
    public int Price { get; set; }
    public int Miles { get; set; }
    private static List<Car> _cars = new List<Car> {};

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;

      _cars.Add(this);

    }

    // public string GetMakeModel()
    // {
    //   return _makeModel;
    // }

    // public int GetPrice()
    // {
    //   return _price;
    // }

    // public void SetPrice(int newPrice)
    // {
    //   _price = newPrice;
    // }

    // public int GetMiles()
    // {
    //   return _miles;
    // }

    public bool WorthBuying(int maxPrice)
    {
      return (Price < maxPrice);
    }

    public static string MakeSound(string sound)
    {
      return "Our cars go " + sound;
    }

    public static List<Car> GetAll()
    {
      return _cars;
    }
  }
}