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

    [HttpGet("/itineraries/{itineraryId}/trips/new"")]
    public ActionResult New(int itineraryId)
    {
      Itinerary itinerary = Itinerary.Find(itineraryId);
      return View(itinerary);
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

    [HttpGet("/trips/{id}")]
    public ActionResult Show(int id)
    {
      Trip foundTrip = Trip.Find(id);
      return View(foundTrip);
    }

    [HttpGet("/itineraries/{itineraryId}/trips/{tripId}")]
    public ActionResult Show(int itineraryId, int tripId)
  {
    Trip trip = Trip.Find(tripId);
    Itinerary itinerary = Itinerary.Find(itineraryId);
    Dictionary<string, object> model = new Dictionary<string, object>();
    model.Add("trip", trip);
    model.Add("itinerary", itinerary);
    return View(model);
  }
  }
}