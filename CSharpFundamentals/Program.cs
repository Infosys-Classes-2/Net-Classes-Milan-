// See https://aka.ms/new-console-template for more information
using System;

// Day 1 work 
/* 
Console.Write("What is your FullName?");
var fullName =Console.ReadLine();
var len= fullName.IndexOf(" ");
var firstName = fullName.Substring(0,len);
Console.WriteLine($"Hello, {firstName}"); */


// Day 2 work

/* 
Convert the given text to uppercase>
Console.WriteLine("Enter the text to convert to UPPERCASE:");
string text =Console.ReadLine();
string converted = text.ToUpper();
Console.WriteLine($"The Converted Text is: {converted}");
 */


//  work 2.2 Convert Meter to Feet

/* Console.WriteLine("Enter the length in meters");
var Meter = Console.ReadLine();
double convert = double.Parse(Meter);
Console.WriteLine($"the {meter} is converted from string to double {convert}");
var feet = 3.2808 * convert;
Console.WriteLine($"The {Meter} is {feet} feet");
 */


/* ASSIGNMENT Program to calculate area of circle. */


/* Console.WriteLine("Enter the radius of Circle");
var radius =Console.ReadLine();
double convertedRadius =double.Parse(radius);
var area = 2*3.14*convertedRadius;
Console.WriteLine($"The Area of circle is,{area}"); */



/* Program to convert days to years, months, weeks and days. */

Console.WriteLine("Enter the number of Days :");
double days= double.Parse(Console.ReadLine());
double years = days/365;
double months = days/30;
double weeks =  days/7;
Console.WriteLine($"The {days} days, consits of {years} Years, {months} Months, {weeks} Weeks and {days} Days.");
