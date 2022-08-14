using System;

/// PASSUNG TYPE AS A PARAMETER
class Generic
{

    // now the Print() method is Generic
    internal void print<T>(T x)
    {
        Console.WriteLine(x);
    }
}

class TestForGeneric
{
    void ForGeneric()
    {
        Generic generic = new();
        generic.print<string>("hello there");
        generic.print<float>(2122.3f);
        generic.print<bool>(true);
    }
}
