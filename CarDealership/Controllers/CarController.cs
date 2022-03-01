using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
  public class CarsController : Controller
  {

    [HttpGet("/cars")]
    public ActionResult Index()
    {
      List<Car> allItems = Car.GetAll();
      return View(allItems);
    }

    [HttpGet("/cars/add")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/cars")]
    public ActionResult Create (
      int year,
      string make,
      string model,
      int price,
      int miles
      )
    {
      Car myCar = new Car(year, make, model, price, miles);
      return RedirectToAction("Index");
    }
  }
}