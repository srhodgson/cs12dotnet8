﻿namespace Packt.Shared;
using System.Diagnostics.CodeAnalysis; // To use [SetsRequiredMembers]

public class Book
{
    // Needs .Net 7 or later as well as C# 11 or later 
    public required string? Isbn;
    public required string? Title;
    // Works with any version of .NET
    public string? Author;
    public int PageCount;

    // Constructor for use with object initialiser syntax
    public Book() { }

    // Constructor with parameters to set required fields 
    [SetsRequiredMembers]
    public Book(string? isbn, string? title)
    {
        Isbn = isbn;
        Title = title;
    }
}
