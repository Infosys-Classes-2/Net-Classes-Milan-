// Parallel Programming  :  TPl < Task parallel Library >
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;

public class LearnParallel
{
    int[] numbers = { 2, 4, 4, 4, 4, 5, 7, 7, 5, 9 };

    public void Do()
    {
        //Sequential Version
        foreach (var num in numbers)
        {
            Thread.Sleep(1000);
            var f = GetFactorial(num);
            Console.WriteLine($"{num}! = {f}");
        }
        // Parallel version>
        Console.WriteLine("This is Parallel version");
        Parallel.ForEach(
            numbers,
            num =>
            {
                var f = GetFactorial(num);
                Console.WriteLine($"{num}! = {f}");
            }
        );
    }

    private long GetFactorial(long n)
    {
        if (n == 0 || n == 1)
            return 1;
        return n * GetFactorial(n - 1);
    }
}

// Asynchronous Programming  : async, await
// Non blocking

public class LearnAsync
{
    async Task GetSomething()
    {
        await GetSomething1();
        await GetSomething2();
    }

    private async Task GetSomething2()
    {
        await Task.Delay(1000);
    }

    private async Task GetSomething1()
    {
        await Task.Delay(1000);
    }
}
