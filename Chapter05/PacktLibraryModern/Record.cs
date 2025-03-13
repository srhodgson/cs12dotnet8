namespace Packt.Shared;

public class ImmutablePerson
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
}

public record ImmutableVehicle
{
    public int Wheels { get; init; }
    public string? Color { get; init; }
    public string? Brand { get; init; }
}