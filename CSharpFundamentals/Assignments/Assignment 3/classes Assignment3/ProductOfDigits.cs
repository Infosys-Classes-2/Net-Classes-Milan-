using System;

class ProductOfDigit
{
    public string number;

    internal int GetProduct(string number)
    {
        int product = 1;
        for (int i = 0; i < number.Length; i++)
        {
            product = product * (number[i] - 48);
        }
        return product;
    }
}

class Fibonacci
{
    internal int FindFibonacci(int num)
    {
        if (num <= 2)
        {
           return num -1 ;
        }
        else{
        
           return FindFibonacci (num - 1) 
           + FindFibonacci(num - 2);
        }
    
    }

     internal long GetNthFibIterative(int n)
    {
        long[] series = new long[n];
        series[0] = 0;
        series[1] = 1;

        for (int i = 2; i < n; i++)
        {
            series[i] = series[i - 1] + series[i - 2];
        }

        return series[n - 1];
    }
}

