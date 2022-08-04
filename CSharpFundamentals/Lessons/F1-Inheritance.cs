using System;

// SINGLE INHERITANCE
public class LivingThings
{
    public string food;
    public string scientificName;
    public void eat()
    {
        Console.WriteLine($"The Living things eats {food}");
    }

}
public class Plant : LivingThings
{
    public bool flowring;
    public int leafCount;
    public void PrintPlantDetail()
    {
        var x = flowring ? "Flowering" : "Non-Flowring";

        Console.WriteLine($"The plant is {x}");
    }
}
public class Animal : LivingThings
{
    public byte noOfLegs;
    public AnimalCategory type;

    public void PrintAnimalDetail()
    {
        var x = type == AnimalCategory.Vertibrates ? "Have Bones" : "Have no bones";
        Console.WriteLine($"The animal {x}");
    }

}


// THIS IS ENUM <Keep this outside of class on different file>
//  ENUMS IS REPRESENTED IN integer only    
public enum AnimalCategory
{
    Vertibrates,
    Invertibrates
}
// MULTILEVEL INHERITANCE

public class Human : Animal
{

}

// MulLITPLE INHERITANCE IS POSSIBLE THROUGH INTERFACE ONLY
// INTERFACE IS IMPLEMENTED ONLY NOT INHERITATED
public class YarsaGumba : Plant, IAnimal
{
    public void PrintAnimalDetail()
    {
        throw new NotImplementedException();
    }
}

public interface IAnimal
{
    public void PrintAnimalDetail();
}