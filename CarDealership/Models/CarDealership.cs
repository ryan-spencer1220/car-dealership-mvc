using System;
using System.Collections.Generic;


namespace CarDealership.Models {

  public class Car
  {
    public int Year { get; }
    public string Make { get; }
    public string Model { get; }
    public int Price { get; set;}
    public int Miles { get; }

    public Car(int year, string make, string model, int price, int miles)
    {
      Year = year;
      Make = make;
      Model = model;
      Price = price;
      Miles = miles;
      _cars.Add(this);
    }
      // Car volkswagen = new Car(1974 ,"Volkswagen", "Thing", 1100, 368792);
      // Car yugo = new Car(1980, "Yugo", "Koral", 700, 56000);
      // Car ford = new Car(1988, "Ford", "Country Squire", 1400, 239001);
      // Car amc = new Car(1976, "AMC", "Pacer", 400, 198000);

    private static  List<Car> _cars = new List<Car>() {};
    public static List<Car> GetAll() 
    {
      return _cars;
    }

  }


}