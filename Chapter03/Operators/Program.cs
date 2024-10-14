﻿#region Exploring unary operators
int a = 3;
int b = a++;
WriteLine($"a is {a}, b is {b}");

int c = 3;
int d = ++c;
WriteLine($"a is {c}, b is {d}");
#endregion

int e = 11;
int f = 3;
WriteLine($"e is {e}, f is {f}");
WriteLine($"e + f = {e + f}");
WriteLine($"e - f = {e - f}");
WriteLine($"e * f = {e * f}");
WriteLine($"e / f = {e / f}");
WriteLine($"e % f = {e % f}");

double g = 11.0;
WriteLine($"g is {g:N1}, f is {f}");
WriteLine($"g / f = {g / f}");

bool p = true;
bool q = false;
WriteLine($"AND | p     | q ");
WriteLine($"p   | {p & p,-5} | {p & q,-5}");
WriteLine($"q   | {q & p,-5} | {q & q,-5}");
WriteLine();
WriteLine($"OR | p     | q ");
WriteLine($"p   | {p | p,-5} | {p | q,-5}");
WriteLine($"q   | {q | p,-5} | {q | q,-5}");
WriteLine();
WriteLine($"XOR | p     | q ");
WriteLine($"p   | {p ^ p,-5} | {p ^ q,-5}");
WriteLine($"q   | {q ^ p,-5} | {q ^ q,-5}");
WriteLine();