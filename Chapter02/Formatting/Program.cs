int numberOfApples = 12;
decimal pricePerApple = 0.33M;
Console.WriteLine(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);
string formatted = string.Format(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);

// Three parameter values can use named arguments.
Console.WriteLine("{0} {1} lived in {2}.",
    arg0: "Roger", arg1: "Cevung", arg2: "Stockholm");
// Four or more parameter values cannot us named arguments.
Console.WriteLine("{0} {1} lived in {2} and worked in the {3} team at {4}.",
    "roger", "Cevung", "Stockholm", "Education", "Optimizely");

    