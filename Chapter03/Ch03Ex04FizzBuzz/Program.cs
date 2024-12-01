/*
  if x is divisible by 3 print fizz
  if x is divisible by 5 print buzz
  if x is divisible by both print fizzbuzz
  otherwise print x
 */

 for (int x = 0; x <= 100; x++)
 {
    if (x % 3 == 0 && x % 5 == 0)
    {
        Write("FizzBuzz");
    }
    else if (x % 5 == 0)
    {
        Write("Buzz");
    }
    else if (x % 3 == 0)
    {
        Write("Fizz");
    }
    else 
    {
        Write(x);
    }

    if (x < 100)
        Write(", ");
    
    if (x % 10 == 0)
        WriteLine();
 }
