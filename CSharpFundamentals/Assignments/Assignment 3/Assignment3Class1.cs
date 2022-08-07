using System;


//Base class 1
public class AirTransport
{
    string type;
    double timetaken;
    string desitnation;
    public void Details()
    {
        Console.WriteLine("We have reached the Destination");
    }


}




public class Airplane : AirTransport
{
    string name;
    double topSpeed;
    short totalSeats;
    double totalFare;

}

public interface IHotairBaloon
{

}
