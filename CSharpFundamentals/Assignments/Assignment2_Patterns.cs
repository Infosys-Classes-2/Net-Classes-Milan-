using System;

internal class Pattern1
{

    internal void PrimeNum()
    {

        bool isPrime = true;
        Console.WriteLine("the Prime numbers:");
        for (short num = 2; num <= 500; num++)
        {
            isPrime = true;
            for (short j = 2; j <= 500; j++)
            {
                if (num != j && num % j == 0)
                {
                    isPrime = false;
                    break;
                }

            }
            if (isPrime)
            {
                Console.Write("\t" + num);
            }


        }


    }


    internal void PatternOne()
    {

        for (short row = 1; row <= 4; row++)
        {
            for (short col = 1; col <= row; col++)
            {
                Console.Write(col + " ");
            }
            Console.WriteLine();
        }



    }
    public void PrintPattern2()
    {
        int rows = 10;
        for (int i = 1; i <= rows; i++)
        {
            for(int j = rows -1; j >= i; j--)
            {                
                Console.Write(" ");
            }

            for(int j = 1; j <= 2 * i - 1; j++)
            {                
                Console.Write("*");
            }
            Console.WriteLine();            
        }
    }


}