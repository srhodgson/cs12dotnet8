using System.Net.Http.Headers;
using System.Reflection.Metadata;
using Packt.Shared; // To use Person
using Fruit = (string Name, int Number); // Aliasing a tuple type

ConfigureConsole(useComputerCulture: true); // Sets current culture to US English.
// Alternatives:
// ConfigureConsole(useComputerCulture: true); // Use your own culture
// ConfigureConsole(culture: "fr-FR"); // Use French culture

// Person bob = new Person(); // C# 1 or later
// var bob = new Person(); // C# 3 or later 
Person bob = new(); // C# 9 or later 
bob.Name = "Bob Smith";
bob.Born = new DateTimeOffset(
    year: 1965, month: 12, day: 22,
    hour: 16, minute: 28, second: 0,
    offset: TimeSpan.FromHours(-5));
WriteLine(format: "{0} was born on {1:D}.", // Long date
arg0: bob.Name, arg1: bob.Born);
bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
WriteLine(
    format: "{0}'s favorite wonder is {1}. It's integer is {2}.",
    arg0: bob.Name,
    arg1: bob.FavoriteAncientWonder,
    arg2: (int)bob.FavoriteAncientWonder);
bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon |
                 WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
// bob.BucketList = (WondersOfTheAncientWorld)18;
WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");

// Works with all versions of C#
Person alfred = new Person();
alfred.Name = "Alfred";
bob.Children.Add(alfred);

// Works with C# 3 and later
bob.Children.Add(new Person { Name = "Bella" });

// Works with C# 9 and later 
bob.Children.Add(new() { Name = "Zoe" });
WriteLine($"{bob.Name} has {bob.Children.Count} children:");
for (int childIndex = 0; childIndex < bob.Children.Count; childIndex++)
{
    WriteLine($"> {bob.Children[childIndex].Name}");
}

Person alice = new()
{
    Name = "Alice Jones",
    Born = new(1998, 3, 7, 16, 28, 0,
    // This is an optional offset from UTC time zone
    TimeSpan.Zero)
};
WriteLine(format: "{0} was born on {1:d}.", // Short date
arg0: alice.Name, arg1: alice.Born);

BankAccount.InterestRate = 0.012M; // Store a shared value in static field
BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;
WriteLine(format: "{0} earned {1:C} interest.",
    arg0: jonesAccount.AccountName,
    arg1: jonesAccount.Balance * BankAccount.InterestRate);

BankAccount gerrierAccount = new();
gerrierAccount.AccountName = "Ms. Gerrier";
gerrierAccount.Balance = 98;
WriteLine(format: "{0} earned {1:C} interest.",
    arg0: gerrierAccount.AccountName,
    arg1: gerrierAccount.Balance * BankAccount.InterestRate);

// Constant fields are accessible via the type
WriteLine($"{bob.Name} is a {Person.Species}");

// Readonly fields are accessible via the variable.
WriteLine($"{bob.Name} was born on {bob.HomePlanet}");

/*
Book book = new()
{
    Isbn = "978-1803237800",
    Title = "C# 12 and .NET 8 - Modern Cross-Platform Development Fundamentals"
};
*/

Book book = new(isbn: "978-1803237800",
    title: "C# 12 and .NET 8 - Modern Cross-Platform Development Fundamentals")
{
    Author = "Mark J. Price",
    PageCount = 821
};

WriteLine("{0}: {1} written by {2} has {3:N0} pages",
    book.Isbn, book.Title, book.Author, book.PageCount);

Person blankPerson = new();
WriteLine(format:
    "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
    arg0: blankPerson.Name,
    arg1: blankPerson.HomePlanet,
    arg2: blankPerson.Instantiated);

Person gunny = new(initialName: "Gunny", homePlanet: "Mars");
WriteLine(format:
    "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd.}",
    arg0: gunny.Name,
    arg1: gunny.HomePlanet,
    arg2: gunny.Instantiated);

bob.WriteToConsole();
WriteLine(bob.GetOrigin());

WriteLine(bob.SayHello());
WriteLine(bob.SayHello("Emily"));

WriteLine(bob.OptionalParameters(3));
WriteLine(bob.OptionalParameters(3, "Jump!", 98.5));
WriteLine(bob.OptionalParameters(3, number: 52.7, command: "Hide!"));
WriteLine(bob.OptionalParameters(3, "Poke!", active: false));

int a = 10;
int b = 20;
int c = 30;
int d = 40;
WriteLine($"Before: a={a}, b={b}, c={c}, d={d}");
bob.PassingParameters(a, b, ref c, out d);
WriteLine($"After: a={a}, b={b}, c={c}, d={d}");

int e = 50;
int f = 60;
int g = 70;
WriteLine($"Before: e={e}, f={f}, g={g}, h doesn't exist yet!");
// Simplified C#7 or later syntax fopr the out parameter 
bob.PassingParameters(e, f, ref g, out int h);
WriteLine($"After: e={e}, f={f}, g={g}, h={h}");

WriteLine();

(string, int)fruit = bob.GetFruit();
WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

WriteLine();

// Without an aliased tuple type
// var fruitNamed = bob.GetNamedFruit();
// With an aliased tuple type
Fruit fruitNamed = bob.GetNamedFruit();
WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}");

WriteLine();

var thing1 = ("Neville", 4);
WriteLine($"{thing1.Item1} has {thing1.Item2} children.");
var thing2 = (bob.Name, bob.Children.Count);
WriteLine($"{thing2.Name} has {thing2.Count} children");

WriteLine();

(string fruitName, int fruitNumber) = bob.GetFruit();
WriteLine($"Deconstructed tuple: {fruitName}, {fruitNumber}");

WriteLine();

var (name1, dob1) = bob; // Implicitly calls the Deconstruct method.
WriteLine($"Deconstructed person: {name1}, {dob1}");
var (name2, dob2, fav2) = bob;
WriteLine($"Deconstructed person: {name2}, {dob2}, {fav2}");

WriteLine();

// Change to -1 to make the exception handling code execute 
int number = -1;
try
{
    WriteLine($"{number}! is {Person.Factorial(number)}");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType()} says: {ex.Message} number was {number}.");
}

WriteLine();

Person sam = new()
{
    Name = "Sam",
    Born = new(1969, 6, 25, 0, 0, 0, TimeSpan.Zero)
};
WriteLine(sam.Origin);
WriteLine(sam.Greeting);
WriteLine(sam.Age);

WriteLine();

sam.FavoriteIceCream = "Chocolate Fudge";
WriteLine($"Sam's favorite ice-cream is {sam.FavoriteIceCream}");
string color = "Red";
try
{
    sam.FavoritePrimaryColor = color;
    WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}");
}
catch (Exception ex)
{
    WriteLine("Tried to set {0} to '{1}' : {2}",
        nameof(sam.FavoritePrimaryColor), color, ex.Message);
}

bob.FavoriteAncientWonder = WondersOfTheAncientWorld.ColossusOfRhodes;

WriteLine();

sam.Children.Add(new()
{
    Name = "Charlie",
    Born = new(2010, 3, 18, 0, 0, 0, TimeSpan.Zero)
});

sam.Children.Add(new()
{
    Name = "Ella",
    Born = new(2020, 12, 24, 0, 0, 0, TimeSpan.Zero)
});

// Get using Children list
WriteLine($"Sam's first child is {sam.Children[0].Name}");
WriteLine($"Sam's second child is {sam.Children[1].Name}");

// Get using the int indexer 
WriteLine($"Sam's first child is {sam[0].Name}.");
WriteLine($"Sam's second child is {sam[1].Name}");

// Get using the string indexer 
WriteLine($"Sam's child named Ella is {sam["Ella"].Age}");

WriteLine();

// An array containing a mix of passenger types.
Passenger[] passengers = {
    new FirstClassPassenger { AirMiles = 1_419, Name = "Suman" },
    new FirstClassPassenger { AirMiles = 16_562, Name = "Lucy" },
    new BusinessClassPassenger { Name = "Janice" },
    new CoachClassPassenger { CarryOnKG = 25.7, Name = "Dave" },
    new CoachClassPassenger { CarryOnKG = 0, Name = "Amit" },
};
foreach (Passenger passenger in passengers)
{
    decimal flightCost = passenger switch
    {
        /* C# 8 Syntax
        FirstClassPassenger p when p.AirMiles > 35_000 => 1_500M,
        FirstClassPassenger p when p.AirMiles > 15_000 => 1_750M,
        FirstClassPassenger _ => 2_000M,
        BusinessClassPassenger _ => 1_000M,
        CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
        CoachClassPassenger _ => 650M,
        _ => 800M*/
        // C# 9 or later syntax 
        FirstClassPassenger p => p.AirMiles switch
        {
            > 35_000 => 1_500M,
            > 15_000 => 1_750M,
            _ => 2_000M
        },
        BusinessClassPassenger => 1_000M,
        CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
        CoachClassPassenger => 650M,
        _ => 800M
    };
    WriteLine($"Flight costs {flightCost:C} for {passenger}");
}

WriteLine();

ImmutablePerson jeff = new()
{
    FirstName = "Jeff",
    LastName = "Winger"
};
//jeff.FirstName = "Geoff";

ImmutableVehicle car = new()
{
    Brand = "Mazda MX-5 RF",
    Color = "Soul Red Crystal Metallic",
    Wheels = 4
};
ImmutableVehicle repaintedCar = car with { Color = "Polymetal Grey Metallic" };
WriteLine($"Original car color was {car.Color}");
WriteLine($"New car color is {repaintedCar.Color}");

WriteLine();

AnimalClass ac1 = new() { Name = "Rex" };
AnimalClass ac2 = new() { Name = "Rex" };
WriteLine($"ac1 == ac2: {ac1 == ac2}");
Animalrecord ar1 = new() { Name = "Rex" };
Animalrecord ar2 = new() { Name = "Rex" };
WriteLine($"ar1 == ar2: {ar1 == ar2}");

WriteLine();

Headset vp = new("Apple", "Vision Pro");
WriteLine($"{vp.ProductName} is made by {vp.Manufacturer}");
Headset holo = new();
WriteLine($"{holo.ProductName} is made by {holo.Manufacturer}");
Headset mq = new() { Manufacturer = "Meta", ProductName = "Quest 3" };
WriteLine($"{mq.ProductName} is made by {mq.Manufacturer}");
