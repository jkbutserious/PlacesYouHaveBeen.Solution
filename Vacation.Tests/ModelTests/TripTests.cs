// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using System.Collections.Generic;
// using Vacation.Models;
// using System;

// namespace Vacation.Tests
// {
//   [TestClass]
//   public class TripTests
//   {
//     [TestMethod]
//   public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
//   {
//     //Arrange
//     string city = "Portland";
//     int date = 1;
//     int rating = 1;
//     string city2 = "Seattle";
//     int date2 = 2;
//     int rating2 = 2;
//     Trip newTrip = new Trip(city, date, rating);
//     Trip newTrip2 = new Trip(city2, date2, rating2);

//     //Act
//     Trip result = Trip.Find(2);

//     //Assert
//     Assert.AreEqual(newTrip2, result);
//   }
//   }
// }