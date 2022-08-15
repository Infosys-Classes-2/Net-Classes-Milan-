// Language Integrated Query (LINQ)

using System;
using System.Collections.Generic;
using System.Linq;

public class LINQ
{
    int[] numbers = { 3, 4, 5, 6, 7, 8, 9, 23, 44, 56, 67, 89, };

    public void LearnLINQ()
    {
        // 1. Fetch all even Numbers on Numbers
        //Mehotd Syntax
        var evenNumbers = numbers.Where(n => n % 2 == 0);

        //Expression Syntax
        evenNumbers = from n in numbers where n % 2 == 0 select n;

        // 2.Fetch odd numbers in Numbers
        var oddNumbers = numbers.Where(n => n % 2 != 0);

        // 3. Fetch all perfect Squares from numbers?
        var perfectSquare = numbers.Where(x => PerfectSquare(x));

        // 4. Find Cubes of all the item Present in numbrs
        var cubes = numbers.Select(x => x * x * x);

        // 5. Get Square of all even numbers in Numbers
        var square = numbers.Where(x => x % 2== 0 ).Select(x=> x*x);
    }

    private bool PerfectSquare(int n)
    {
        var sr = Math.Sqrt(n);
        var product = sr * sr;
        return product == n;
    }
}
