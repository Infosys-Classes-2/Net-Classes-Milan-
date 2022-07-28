// See https://aka.ms/new-console-template for more information
using System;

//  Day 1 work 

Console.Write("What is your FullName?");
var fullName =Console.ReadLine();
var len= fullName.IndexOf(" ");
var firstName = fullName.Substring(0,len);

Console.WriteLine($"Hello, {firstName}");


// Day 2 work

