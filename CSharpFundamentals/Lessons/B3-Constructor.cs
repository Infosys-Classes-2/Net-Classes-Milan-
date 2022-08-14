using System;

public class Shape2D
{
    //CONSTRUCTOR 
    //THIS IS DEFAULT CONSTRUCTOR ... DOES NOT RETURN ANY VALUE
    
   public Shape2D()
    {

    } 
   
    // PARAMETERTIZED CONSTRUCTOR
    public Shape2D(string n)
    {
        name=n;
    } 

    private string name;
    public void PrintDetail()
    {
        Console.WriteLine($"I am{name}");
    }
}