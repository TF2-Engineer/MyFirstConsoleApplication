// See https://aka.ms/new-console-template for more information
using System;
using System.Data;
using System.Xml.Serialization;

string name = "Jared";
string state = "California";
Console.WriteLine("My name is " + name + ".");
Console.WriteLine("I am from " + state + ".");
DateTime date = DateTime.Now;
Console.WriteLine(date);
DateTime christmas = new DateTime(2023, 12, 25);
TimeSpan days_til = christmas - date;
Console.WriteLine("The number of days until Christmas are " + days_til.Days);
double width, height, woodLength, glassArea;
string widthString, heightString;
Console.WriteLine("Please enter a width: ");
widthString = Console.ReadLine();
width = double.Parse(widthString);
Console.WriteLine("Please enter a height: ");
heightString = Console.ReadLine();
height = double.Parse(heightString);
woodLength = 2 * (width + height) * 3.25;
glassArea = 2 * (width * height);
Console.WriteLine("The length of the wood is " + woodLength + " feet");
Console.WriteLine("The area of the glass is " + glassArea + " square metres");
