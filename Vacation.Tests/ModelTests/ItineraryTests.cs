using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vacation.Models;
using System.Collections.Generic;
using System;

namespace Vacation.Tests
{
  [TestClass]
  public class Vacations
  {
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

  }
}