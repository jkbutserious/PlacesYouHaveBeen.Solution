using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Vacation.Models;

namespace Vacation.Controllers
{
  public class ItinerariesController : Controller
  {
    [HttpGet("/itineraries")]
    public ActionResult Index()
    {
      List<Itinerary> allItineraries = Itinerary.GetAll();
      return View(allItineraries);
    }

    [HttpGet("/itineraries/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/itineraries")]
    public ActionResult Create(string itineraryName)
    {
      Itinerary newItinerary = new Itinerary(itineraryName);
      return RedirectToAction("Index");
    }

    [HttpGet("/itineraries/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Itinerary selectedItinerary = Itinerary.Find(id);
      List<Trip> itineraryDestinations = selectedItinerary.Destinations;
      model.Add("itinerary", selectedItinerary);
      model.Add("trips", itineraryDestinations);
      return View(model);
    }
    
    [HttpPost("/itineraries/{id}/trips")]
    public ActionResult Create(int id, string cityName, int date, int rating)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Itinerary foundItinerary = Itinerary.Find(id);
      Trip newTrip = new Trip(cityName, date, rating);
      foundItinerary.AddTrip(newTrip);
      List<Trip> itineraryTrips = foundItinerary.Destinations;
      model.Add("trips", itineraryTrips);
      model.Add("itinerary", foundItinerary);
      return View("Show", model);
    }
  } 
}