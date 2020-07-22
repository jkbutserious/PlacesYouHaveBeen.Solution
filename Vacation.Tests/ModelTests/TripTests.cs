using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Vacation.Models;
using System;

namespace Vacation.Tests
{
  [TestClass]
  public class Vacations
  {
    [TestMethod]
  public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
  {
    //Arrange
    string city = "Portland";
    int date = 1;
    int rating = 1;
    Trip newTrip = new Trip(city, date, rating);

    //Act
    int result = newTrip.Id;

    //Assert
    Assert.AreEqual(1, result);
  }
  }
}