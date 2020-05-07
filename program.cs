using System;
using System.Collections.Generic;
using Animals;

namespace Tracker
{
  public class Wildlife
  {
    static void Main()
    {
      List<Species> SpeciesList = new List<Species>();
      SpeciesList.Add(new Species("Deer","White tail", "genderfluid" ));
      SpeciesList.Add(new Species("Elf","Wood","Female"));
      SpeciesList.Add(new Species("Fox","Arctic", "male"));
   

      bool trackingAnimals = true;

      while(trackingAnimals)
      {
        
        // if ("Y") {
        //   Console.WriteLine("What species is it?")
        //   Console.WriteLine("What breed is it?")
        //   Console.WriteLine("What gender is it?")
        //   ourtrackedanimallist.Add(Species animal = new Species (blah, blah, blah))
        Console.WriteLine("Do you wish to track a new animal? N/n to quit.");
        string trackMore = Console.ReadLine();

        if (trackMore == "n" || trackMore == "N")
        {
          trackingAnimals = false;
        }
      }
    }
  }
}

