using static System.Console;
WriteLine("* Top-Level functions example");
WhatsMyNamespace(); // Call the function

void WhatsMyNamespace() // Define a local fucntion
{
    WriteLine("Namespace of Program class: {0}",
        arg0: typeof(Program).Namespace ?? "null");
}