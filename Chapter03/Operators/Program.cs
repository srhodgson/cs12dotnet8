string rowSeparator = new string('-', count: 104);
#region Exloring unary operators
int a = 3;
int b = a++;
WriteLine($"a is {a}, b is {b}");
WriteLine(rowSeparator);
int c = 3;
int d = ++c; // Prefix means increment c before assigning it
WriteLine($"c is {c}, d is {d}");
WriteLine(rowSeparator);
#endregion

int e = 11;
int f = 3;
WriteLine($"e is {e}, f is {f}");
WriteLine($"e + f = {e + f}");
WriteLine($"e - f = {e - f}");
WriteLine($"e * f = {e * f}");
WriteLine($"e / f = {e / f}");
WriteLine($"e % f = {e % f}");
WriteLine(rowSeparator);
double g = 11.0;
WriteLine($"g is {g:N1}, f is {f}");
WriteLine($"g / f = {g / f}");
WriteLine($"g % f = {g % f}");
WriteLine(rowSeparator);
bool p = true;
bool q = false;
WriteLine($"AND    | P     | Q    ");
WriteLine($"p      | {p & p,-5} | {p & q,-5}");
WriteLine($"q      | {q & p,-5} | {q & q,-5}");
WriteLine();
WriteLine($"OR    | P     | Q    ");
WriteLine($"p      | {p | p,-5} | {p | q,-5}");
WriteLine($"q      | {q | p,-5} | {q | q,-5}");
WriteLine();
WriteLine($"XOR    | P     | Q    ");
WriteLine($"p      | {p ^ p,-5} | {p ^ q,-5}");
WriteLine($"q      | {q ^ p,-5} | {q ^ q,-5}");
WriteLine();
WriteLine($"p & DoStuff() = {p & DoStuff()}");
WriteLine($"q & DoStuff() = {q & DoStuff()}");
WriteLine();
WriteLine($"p && DoStuff() = {p && DoStuff()}");
WriteLine($"q && DoStuff() = {q && DoStuff()}");


static bool DoStuff()
{
    WriteLine("I am doing some stuff");
    return true;
}