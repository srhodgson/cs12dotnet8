// All types in this file will be defined in this file-scoped namespace
namespace Packt.Shared;

public class Person : object
{
    #region Fields: Data or state for this person
    public string? Name; // ? means it can be null
    public DateTimeOffset Born;
    public WondersOfTheAncientWorld FavoriteAncientWonder;
    public WondersOfTheAncientWorld BucketList;
    public List<Person> Children = new();
    // Constant fields: Values that are fixed at compilation
    public const string Species = "Homo Sapiens";
    // Read-only fields: Values that can be set at runtime
    public readonly string HomePlanet = "Earth";
    public readonly DateTime Instantiated;
    #endregion

    #region Constructors: Called when using new to instantiate a type 
    public Person()
    {
        // Constructors can set default values for fields including any read-only
        Name = "Unknown";
        Instantiated = DateTime.Now;

    }

    public Person(string initialName, string homePlanet)
    {
        Name = initialName;
        HomePlanet = homePlanet;
        Instantiated = DateTime.Now;
    }
    #endregion

    #region Methods: Actions the type can perform 
    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {Born:dddd}.");
    }

    public string GetOrigin()
    {
        return $"{Name} was born on {HomePlanet}";
    }

    public string SayHello()
    {
        return $"{Name} says 'Hello!'.";
    }

    public string SayHello(string name)
    {
        return $"{Name} says 'Hello, '{Name}!'";
    }

    public string OptionalParameters(int count, string command = "Run!", double number = 0.0,
        bool active = true)
    {
        return string.Format(
            format: "command is {0}, number is {1}, active is {2}",
            arg0: command,
            arg1: number,
            arg2: active);
    }

    public void PassingParameters(int w, int x, ref int y, out int z)
    {
        // out parameters cannot have a default and they must be initialised inside the method.
        z = 100;
        // Increment each parameter except the read-only x.
        w++;
        // x++; // Give a compiler error!
        y++;
        z++;
        WriteLine($"In the method: w={w}, x={x}, y={y}, z={z}");
    }

    // Method that returns a tuple: (string, int)
    public (string, int) GetFruit()
    {
        return ("Apples", 5);
    }

    // Method that returns a tuple with named fields.
    public (string Name, int Number) GetNamedFruit()
    {
        return(Name: "apples", Number: 5);
    }
    
    // Deconstructors: Break down this object into parts.
    public void Deconstruct(out string? name, out DateTimeOffset dob)
    {
        name = Name;
        dob = Born;
    }

    public void Deconstruct(out string? name, out DateTimeOffset dob, out WondersOfTheAncientWorld fav)
    {
        name = Name;
        dob = Born;
        fav = FavoriteAncientWonder;
    }
    #endregion
}
