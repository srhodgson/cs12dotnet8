﻿object height = 1.88; // Storing a double in an object.
object name = "Steve"; // Storing a string in an object.
Console.WriteLine($"{name} is {height} meters tall.");
// int length1 = name.Length; // This gives a compile error 
int length2 = ((string)name).Length; // Cast name to a string.
Console.WriteLine($"{name} has {length2} characters.");

Console.WriteLine();

dynamic something;
// Storing an array of int values in a dynamic object.
// An array of any type hase a Length property.
something = new[] { 3, 5, 7 };
// Storing an int in a dynamic object.
// int does not have a Length property.
// something = 12;
// Storing a string in a dynamic object.
// string has a Length property.
// something = "steve";
// This compiles but might throw an exception at run time.
Console.WriteLine($"The length of something is {something.Length}");
// Output the type of the something variable.
Console.WriteLine($"something is a {something.GetType()}");

Console.WriteLine();

var population = 67_000_000; // 67 million in UK
var weight = 1.88; // in kilograms
var price = 4.99M; // in pounds sterling 
var fruit = "Apples"; // string values use double-quote 
var letter = 'z'; // char values use single-quotes 
var happy = true; // Booleans can only be true or false.
