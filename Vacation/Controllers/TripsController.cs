using Microsoft.AspNetCore.Mvc;
using Vacation.Models;
using System.Collections.Generic;

namespace Vacation.Controllers
{
  public class TripsController : Controller
  {
    [HttpGet("/trips")]
    public ActionResult Index()
    {
      List<Trip> trips = Trip.GetAll();
      return View(trips);
    }

    [HttpGet("/trips/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/trips")]
    public ActionResult Create(string city, int date, int rating)
    {
      Trip myTrip = new Trip(city, date, rating);
      return RedirectToAction("Index");
    }
    [HttpPost("/trips/delete")]
    public ActionResult DeleteAll()
    {
      Trip.ClearAll();
      return View();
    }

  }
}