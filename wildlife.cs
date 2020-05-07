using System;

namespace Animals
{
  public class Species
  {
    private string _Breed;
    private string _Gender;
    private string _SpeciesName;
   
    public Species(string breed, string gender, string speciesName)
    {
    _Breed = breed;
    _Gender = gender;
    _SpeciesName = speciesName;
    }

  }
  
}