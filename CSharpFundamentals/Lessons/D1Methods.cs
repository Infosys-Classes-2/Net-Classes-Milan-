using System;


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

    public string GetInitials( string fullname){

        var nameParts = fullname.Split(" ");
        var len = nameParts.Length;
        var first = nameParts[0][0];
        var last =nameParts[len-1][0];

        var initials = $"{first} {last}";
        return initials;

    }

}