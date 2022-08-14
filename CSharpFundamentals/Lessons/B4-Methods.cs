using System;
using System.Linq;

public class MethodsLearning
{
    // Returns Nothing , Takes no arguments
    void PrintHello()
    {
        Console.WriteLine("Nepal");
    }

    // Returns nothing , Takes some argueemnets

    public void PrintNepalNTimes(int n) 
    {
        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine("Nepal");
        }
    }

    // Returns some Value take some or no Arguements


    public int Add(int x, int y)
    {
        var sum = x + y;
        return sum;

    }

    public string GetInitials(string fullname)
    {

        var nameParts = fullname.Split(" ");
        var len = nameParts.Length;
        var first = nameParts[0][0];
        var last = nameParts[len - 1][0];

        var initials = $"{first} {last}";
        return initials;

    }

    //Return Multiple values, take no/ some Arguments\

    public (short, short) GetMinMax(short[] numbers) // (short, short)tupple ekai choti ma 2 
                                                     // value pathauda (data, type or return value )lai comma vitra halne
    {
        short min = short.MaxValue, max = short.MinValue;
        foreach (short num in numbers)
        {
            if (num < min)
                min = num;

            if (num > max)
                max = num;
        }
        return (min, max); // return(min, max) topple
    }



    /*  CLASS WORK FIND MINIMUM MAXIMUM AND AVERAGE VALUE FROM ARGUEMENT AND RETURN*/


    public (short, short, int) GetMinMaxAndAverage(short[] numbers)
    {
        short min = short.MaxValue, max = short.MinValue;
        int average = 0;
        int totalNumbers = numbers.Length;
        foreach (short num in numbers)
        {
            if (num < min)
                min = num;

            if (num > max)
                max = num;
            average = num + average;
        }

        int averageOfNumbers = average / totalNumbers;


        return (min, max, averageOfNumbers);
    }


    // Declarative Programing
    public (short, short) GetMinMaxAndAverageDeclarative(short[] numbers)
    {
        short min = numbers.Min();
        short max = numbers.Max();
        //short average = numbers.Average();



        return (min, max);
    }



    //variable number of arguements , named parameters, oprional parameter

    public void Test()
    {
        // Named Parameters
        Add(y: 34, x: 444);
        var product = Multiply(2, 2);
        PrintText ("milan","snatosh","jenny","sanjeev","bishnu","krishna","hari", "prasad");
    }

    public double Multiply(double x, double y, double z = 1) //Here Z is optional arguemnet
    {
        return x * y * z;
    }

    // variable Parameter

    public void PrintText(params String[] names)
    {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
    }

    //Expression bodied members, inline methods
    //=> lyamda operator/ goesto /arrow operator
    public float Divide(float x, float y) => x/y;
}