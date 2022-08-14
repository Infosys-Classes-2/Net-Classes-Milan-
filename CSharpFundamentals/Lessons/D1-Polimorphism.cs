using System;

//ploymorphism

// Static PolyMorphism
// Method overlaoding
public class Vehicle
{
    public virtual void Start()
    {
        Console.WriteLine("The engine is started");
    }

    public void Start(float voltage)
    {
        Console.WriteLine("engine is started with prescribed voltage");
    }
}

// Dynamic polymorphism 
//<This polymorphism is close to Inheritance>


public class Car : Vehicle
{
    public override void Start()
    {
        base.Start();
        Console.WriteLine("The engine was car engine");
    }

    public new void Start(float voltage)
    {
        Console.WriteLine("engine is started with prescribed voltage");
    }
}

class Test2
{
    void Do()
    {
        Car car = new();
        car.Start();
        car.Start(43.4f);
    }
}
