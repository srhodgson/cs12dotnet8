﻿//WriteLine("Before parsing");
//Write("What is your age?");
//string? input = ReadLine();
//try
//{
//    int age = int.Parse(input!);
//    WriteLine($"You are {age} years old.");
//}
//catch (FormatException)
//{
//    WriteLine("The age you entereed is not a valid number format.");
//}
//catch (OverflowException)
//{
//    WriteLine("Your age is a valid number format but it is either too big or too small.");
//}
//catch (Exception ex)
//{
//    WriteLine($"{ex.GetType()} says {ex.Message}");
//}
//WriteLine("After parsing");

WriteLine();


try
{
    checked
    {
        int x = int.MaxValue -1;
        WriteLine($"Initial value: {x}");
        x++;
        WriteLine($"After incrementing: {x}");
        x++;
        WriteLine($"After incrementing: {x}");
        x++;
        WriteLine($"After incrementing: {x}");
    }
}
catch (OverflowException)
{
    WriteLine("The code overflowed but I caught the exception.");
}

WriteLine();

unchecked
{
    int y = int.MaxValue + 1;
    WriteLine($"Initial value: {y}");
    y--;
    WriteLine($"After decrementing: {y}");
    y--;
    WriteLine($"After decrementing: {y}");
}