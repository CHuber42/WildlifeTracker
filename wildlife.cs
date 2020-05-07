using System;

namespace Animals
{
  public class Species
  {
    private string _Breed;
    private string _Gender;
    private string _SpeciesName;
   
    public Species(string speciesName, string breed, string gender)
    {
    _SpeciesName = speciesName;
    _Breed = breed;
    _Gender = gender;
    }
  public string GetName(string speciesName)
  {
    return _SpeciesName;
  }
  public string GetBreed(string breed)
  {
    return _Breed;
  }
  public string GetGender(string gender)
  {
    return _Gender;
  }
  }
  
}