// See https://aka.ms/new-console-template for more information
using System;

//  Day 1 work 

// Console.Write("What is your FullName?");
// var fullName =Console.ReadLine();
// var len= fullName.IndexOf(" ");
// var firstName = fullName.Substring(0,len);

// Console.WriteLine($"Hello, {firstName}");


// Day 2 work
// Convert the given text to uppercase>
// Console.WriteLine("Enter the text to convert to UPPERCASE:");
// string text =Console.ReadLine();
// string converted = text.ToUpper();
// Console.WriteLine($"The Converted Text is: {converted}");

// Convert Meter to Feet
Console.WriteLine("Enter the length in meters");
var Meter = Console.ReadLine();
double convert = double.Parse(Meter);
Console.WriteLine($"the {meter} is converted from string to double {convert}");
var feet = 3.2808 * convert;
Console.WriteLine($"{Meter} is {feet} feet");