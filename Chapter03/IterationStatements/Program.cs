﻿using System.Threading.Tasks.Dataflow;

int x = 0;
while (x < 10) 
{
    WriteLine(x);
    x++;
}

/*string? actualPassword = "Pa$$w0rd";
string? password;
do
{
    Write("Enter your password: ");
    password = ReadLine();
}
while (password != actualPassword);
WriteLine("Correct");*/

for (int y = 1; y <= 10; y++)
{
    WriteLine(y);
}

for (int y = 0; y <= 10; y +=3)
{
    WriteLine(y);
}

string[] names = { "Adam","Barry","Charlie"};
foreach (string name in names) 
{
    WriteLine($"{name} has {name.Length} characters");
}
