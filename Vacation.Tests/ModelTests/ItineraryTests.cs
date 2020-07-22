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
    public void GetId_ReturnsCategoryId_Int()
    {
      //Arrange
      string name = "Test Itinerary";
      Itinerary newItinerary = new Itinerary(name);

      //Act
      int result = newItinerary.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

  }
}