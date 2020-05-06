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
        Console.WriteLine("Do you wish to track a new animal? N/n to quit.");
        string trackMore = Console.ReadLine();

        if (trackMore == "n" || trackMore == "N")
        {
          trackingAnimals = false;
        }
        else
        {
          Console.WriteLine("What species is it?");
          string speciesType = Console.ReadLine();
          Console.WriteLine("What breed is it?");
          string breedType= Console.ReadLine();
          Console.WriteLine("What gender is it?");
          string genderType = Console.ReadLine();


          SpeciesList.Add(new Species (speciesType, breedType, genderType));

          foreach(Species Species in SpeciesList)
          {
          Console.WriteLine(Species.GetName() + " " + Species.GetBreed() + " " + Species.GetGender());
          }
        }
      }
    }
  }
}

