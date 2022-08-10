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
        if (num <= 1)
        {
           return num;
        }
        else{
        
           return FindFibonacci (num - 1) + FindFibonacci(num - 2);
        }
    
    }
}
