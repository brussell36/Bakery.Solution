using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Pierres
{
  public class Bakery
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery! We have Bread and Pastries.");
      Console.WriteLine("Please enter (Bread/Pastry) to specify how many you would like of each.");
      string userOrder = Console.ReadLine();
      if (userOrder == "Bread")
      {
        Console.WriteLine("How many loaves would you like? Enter a number: ");
        Bread newOrder = new Bread(int.Parse(Console.ReadLine()));
        breadOrder = newOrder.BreadValue();
      }
      else if (userOrder == "Pastry")
      {
        Console.WriteLine("How many pastries would you like? Enter a number: ");
        Pastry newOrder = new Pastry(int.Parse(Console.ReadLine()));
        pastryOrder = newOrder.PastryValue();
      }
      Console.WriteLine("You owe $" + breadOrder + pastryOrder);
    }
  }
}

