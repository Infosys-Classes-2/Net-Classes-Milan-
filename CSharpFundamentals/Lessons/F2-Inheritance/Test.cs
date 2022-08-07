using System;
public class TestForRectangle
{
    void CalculateAreas() 
    { 

        Ishape rectangle = new Rectangle(23.4,12.5);
        var area = rectangle.GetArea;
        var parimeter = rectangle.GetParameter;

        Ishape square = new Square( 56.4);
        var squareArea = square.GetArea();
        var squareParameter = square.GetArea();    
    
        Ishape triangle =new Triangle(22.3,44.3,20.3);
        var triangleArea =triangle.GetArea();
        var triangleParameter=triangle.GetParameter();
    }
}
