// Language Integrated Query (LINQ)

using System;
using System.Collections.Generic;
using System.Linq;

public class LINQ
{
    int[] numbers = { 3, 4, 5, 6, 7, 8, 9, 23, 44, 56, 67, 89, };
    List<string> names = new List<string>
    {
        "milannn",              
        "Jenny",
        "dhiraj",
        "santosh",
        "pravin",
        "sonu",
        "ambika",
        "babita",
        "shova",
        "manju",
        "om"
    };

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
        var square = numbers.Where(x => x % 2 == 0).Select(y => y * y);

        // 6. Get first five items after skipping first (2)
        var firstFive = numbers.Skip(2).Take(5);


            //   All and ANY are Quantifiers

        // 7. Check all if All numbers in List are Even
        var checkIfAllEven = numbers.All(x => (x & 1) == 0);

        // 8. Check if any numbrs is even
        var checkIfAnyEven = numbers.Any(x => (x & 1) == 0);

        // 9. Get all Names starting with Letters A
        var namesStringA= names.Where(x=>x.ToUpper().StartsWith('A'));

        //10 . Get all Names with length greater than 5 char
        var nameLength = names.Where(x=>x.Length > 5);
    }

    private bool PerfectSquare(int n)
    {
        var sr = Math.Sqrt(n);
        var product = sr * sr;
        return product == n;
    }
}
