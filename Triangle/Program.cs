using System;
using System.Collections.Generic;
using Triangle;

namespace Triangle
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter the length for Side 1:  ");
      string stringS1 = Console.ReadLine();
      int s1 = int.Parse(stringS1);

      Console.WriteLine("Enter the length for Side 2:  ");
      string stringS2 = Console.ReadLine();
      int s2 = int.Parse(stringS2);

      Console.WriteLine("Enter the length for Side 3:  ");
      string stringS3 = Console.ReadLine();
      int s3 = int.Parse(stringS3);

      Triangle testThis = new Triangle(s1, s2, s3);
      Console.WriteLine(testThis.Classify());
      /* 
      Triangle notATriangle = new Triangle(1, 2, 4);
      Triangle isosceles = new Triangle(4, 2, 4);
      Triangle equilateral = new Triangle(2, 2, 2);
      Triangle scalene = new Triangle(2, 3, 4);

      Console.WriteLine(notATriangle.Classify()); 
      Console.WriteLine(isosceles.Classify()); 
      Console.WriteLine(equilateral.Classify()); 
      Console.WriteLine(scalene.Classify()); 
      */ 

    }
  }
}

/*
namespace Dealership
{
  public class Program
  {
    public static void Main()
    {
      Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, 8, 8);
      Car yugo = new Car("1980 Yugo Koral", 700, 56000, 5, 4);
      Car ford = new Car("1988 Ford Country Squire", 1400, 239001, 1, 1);
      Car amc = new Car("1976 AMC Pacer", 400, 198000, 9, 9);

      List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc};

      foreach(Car automobile in Cars)
      {
        automobile.LowerPrice();
      }
      // yugo.SetPrice(300);

      Console.WriteLine("Enter maximum price: ");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);

      List<Car> CarsMatchingSearch = new List<Car>(0);

      foreach(Car automobile in Cars)
      {
        if (automobile.WorthBuying(maxPrice))
        {
          CarsMatchingSearch.Add(automobile);
        }
      }

      foreach(Car automobile in CarsMatchingSearch)
      {
        Console.WriteLine("----------------------");
        Console.WriteLine(automobile.MakeModel);
        Console.WriteLine(automobile.Miles + " miles");
        Console.WriteLine("The sale price for THIS WEEKEND ONLY is  $" + automobile.Price);
        Console.WriteLine(automobile.SuccessInDakarRally());
        Console.WriteLine(automobile.ResaleValue());
      }
    }
  }
}
*/