using System;
//base class 2
public class LandTransport
{
    int speed;
    double timetaken;
    string desitnation;



}

public class bus : LandTransport, Icar, IHotairBaloon
{



}

public class bike : LandTransport
{
//
}

public interface Icar
{
//
}