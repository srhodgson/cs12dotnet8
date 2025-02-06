using System.Diagnostics; // To use Debug and Trace
using Microsoft.Extensions.Configuration; // To use Configuration-Builder 

string logPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
"log.text");
Console.WriteLine($"Writing to: {logPath}");
TextWriterTraceListener logFile = new(File.CreateText(logPath));
Trace.Listeners.Add(logFile);

#if DEBUG
// Text writer is buffered, so this option calls
// Flush() on all listeners after writing 
Trace.AutoFlush = true;
#endif

Debug.WriteLine("Debug says, I am watching!");
Debug.WriteLine("Trace says, I am watching!");

string settingsFile = "appsettings.json";
string settingsPath = Path.Combine(Directory.GetCurrentDirectory(), settingsFile);
Console.WriteLine("Processing: {0}", settingsPath);
Console.WriteLine("--{0} contents--", settingsFile);
Console.WriteLine(File.ReadAllText(settingsPath));
Console.WriteLine("----");
ConfigurationBuilder builder = new();
builder.SetBasePath(Directory.GetCurrentDirectory());
// Add the settings file to the processed configuration and make it mandatory so
// an exception will be thrown if the file is not found.
builder.AddJsonFile(settingsFile, optional: false, reloadOnChange: true);
IConfigurationRoot configuration = builder.Build();
TraceSwitch ts = new(
    displayName: "PacktSwitch",
    description: "This switch is set via a JSON config");
// Close the text file (also flushes) and release resources.
Debug.Close();
Trace.Close();