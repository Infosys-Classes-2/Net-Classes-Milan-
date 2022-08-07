using System;

public class Triangle : Ishape
{
    // shortcut for construcotr CTOR tab
    public Triangle(double a, double c, double b)
    {
        a = side1;
        b = side2;
        c = side3;
    }

    private double side1;
    private double side2;
    private double side3;

    public double GetParameter() => side1 + side2 + side3;

    public double GetArea()
    {
        var s = GetParameter() / 2;
        var area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        return area;
    }
}
