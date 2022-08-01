using System;
/*  */
internal class Branches
{
     internal void LearnBranching(){

         /* IF ELSE */
        /*  
        var isHuman=true;
        if(isHuman){
            Console.WriteLine("the statement was true");
        }
        else{
            Console.WriteLine("the statement was false");
        }

        
        Console.WriteLine("Enter the Positive or Negative number:");
        short num =short.Parse(Console.ReadLine());
        if(num == 0 )
        {
            Console.WriteLine($"The given number {num}is zero");

        }
        else if(num < 0)
        {
            Console.WriteLine($"The given number {num} is negative");
        }
        else
        {
            Console.WriteLine($"the given number {num} is positive");
        }
 */
        /* Switch Statement */
        
             var today = DateTime.Now.DayOfWeek; /* Casting */
             switch(today)
             {
                case DayOfWeek.Sunday : 
                Console.WriteLine("Today is sunday");
                break;

                 case DayOfWeek.Monday : 
                 Console.WriteLine("Today is monday");
                break;

                 case DayOfWeek.Tuesday : 
                 Console.WriteLine("Today is Tuesday");
                break;
                
                 case DayOfWeek.Wednesday :
                  Console.WriteLine("Today is Wednesday");
                break;

                 case DayOfWeek.Thursday : 
                 Console.WriteLine("Today is Thursday");
                break;

                 case DayOfWeek.Friday : 
                 Console.WriteLine("Today is Friday");
                break;
                
                 case DayOfWeek.Saturday : 
                 Console.WriteLine("Today is Saturday");
                break;
             }
    }
}