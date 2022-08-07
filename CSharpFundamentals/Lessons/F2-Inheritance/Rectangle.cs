using System;

public class Rectangle : Ishape
{

    public Rectangle(double l, double b){
        length =l;
        breadth= b;
    }
    private double length;
    private double breadth;

    public double GetArea() => length * breadth;

    public double GetParameter() => 2 * (length + breadth);
}
