using System;

 internal class PatternWithFunction
{
     internal void PatternOneWithFunction(int x)
    {

        for (short row = 1; row <= x; row++)
        {
            for (short col = 1; col <= row; col++)
            {
                Console.Write(col + " ");
            }
            Console.WriteLine();
        }



    }
 public void PrintPatternTwoWithFunction(int rows)
    {
        
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