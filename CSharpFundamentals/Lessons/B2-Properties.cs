using System;

//Properties

public class Planet
{
    private string name;
    //Full Property
    public string Name{
      get
      {
        return name;
      }
      set
      {
        if (value.Length >5)
        name=value;
      }
    }
  // Auto Implemented Property 
  //for readonly property Remove Set
    public double Mass{get; set;}
// ReadOnly Property
// In line initialize garna use => '='
    public double DistanceFromSun { get;  }
   
}

public class Test3
{
    void Do()
    {
        Planet earth = new();
        earth.Name ="Earth";
        earth.Mass=354.34534; 

    }
}






