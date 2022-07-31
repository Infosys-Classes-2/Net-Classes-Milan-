
/* Animal */
using System;
  class Animal
{
    //Members : fields, methods
    // Access modifiers : public, private, internal, protected
    public float weight ;
     internal string type;

    // methods
    void Eat()

    {
        Console.WriteLine(type + "" +"is Eating" );
    }

     internal void PrintDetails()
    {
        Eat();
        Console.WriteLine($"Weight of the {type} is {weight} kg");
    }

}
class Test 
{
    public static void Main ()
    {
        Animal cow =new();
        Animal goat=new();
        Animal buffalo =new();
        Animal deer = new ();
        Animal fish =new Animal();

        cow.weight = 345.9f ;
        cow.type = "cow";
        cow.PrintDetails();
    }
}