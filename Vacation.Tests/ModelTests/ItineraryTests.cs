using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vacation.Models;
using System.Collections.Generic;
using System;

namespace Vacation.Tests
{
  [TestClass]
  public class ItineraryTests : IDisposable
  {

    public void Dispose()
    {
      Itinerary.ClearAll();
      Trip.ClearAll();
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test Itinerary";
      Itinerary newItinerary = new Itinerary(name);

      //Act
      string result = newItinerary.Name;

      //Assert
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void GetId_ReturnsItineraryId_Int()
    {
      //Arrange
      string name = "Test Itinerary";
      Itinerary newItinerary = new Itinerary(name);

      //Act
      int result = newItinerary.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllItineraryObjects_ItineraryList()
    {
      //Arrange
      string name1 = "Test Itinerary1";
      string name2 = "Test Itineray2";
      Itinerary newItinerary1 = new Itinerary(name1);
      Itinerary newItinerary2 = new Itinerary(name2);
      List<Itinerary> newList = new List<Itinerary> { newItinerary1, newItinerary2 };

      //Act
      List<Itinerary> result = Itinerary.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectItinerary_Itinerary()
    {
      //Arrange
      string name1 = "Test Itinerary1";
      string name2 = "Test Itineray2";
      Itinerary newItinerary1 = new Itinerary(name1);
      Itinerary newItinerary2 = new Itinerary(name2);

      //Act
      Itinerary result = Itinerary.Find(2);

      //Assert
      Assert.AreEqual(newItinerary2, result);
    }

    [TestMethod]
    public void AddTrip_AssociatesTripWithItinerary_TripList()
  {
    //Arrange
    string city = "Portland";
    int date = 1;
    int rating = 1;
    Trip newTrip3 = new Trip(city, date, rating);
    string city1 = "Portland";
    int date1 = 1;
    int rating1 = 1;
    Trip newTrip4 = new Trip(city1, date1, rating1);
    List<Trip> newList = new List<Trip> { newTrip3, newTrip4 };
    string name = "Oregon";
    Itinerary newItinerary = new Itinerary(name);
    newItinerary.AddTrip(newTrip3);
    // Console.WriteLine(newItinerary.Destinations);
    
    //Act
    List<Trip> result = newItinerary.Destinations;

    //Assert
    CollectionAssert.AreEqual(newList, result);
  }

  }
}