using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Program
{
  public class Bakery
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery! We have Bread and Pastries.");
      Console.WriteLine("Bread is $5 per loaf and Pastries are $2 each.");
      Console.WriteLine("We are having a sale! If you buy 3 loaves you will get one for free.");
      Console.WriteLine("Pastries are $2 each, but 3 for $5.");
      Console.WriteLine("Please enter how many loaves and pastries you would like to purchase.");    
      Console.WriteLine("How many loaves would you like? Enter a number: ");
      Bread newOrder = new Bread(int.Parse(Console.ReadLine()));
      int breadOrder = newOrder.BreadValue();
      Console.WriteLine("How many pastries would you like? Enter a number: ");
      Pastry newOrder2 = new Pastry(int.Parse(Console.ReadLine()));
      int pastryOrder = newOrder2.PastryValue();
      Console.WriteLine("You owe $" + (breadOrder + pastryOrder) + ", thank you for choosing our bakery.");
    }
  }
}

