namespace BeginnerLearning;

public class Person(string firstName, string lastName, DateOnly birthday)
{

    public string firstName { get; } = firstName;
    public string lastName { get; } = lastName;
    public DateOnly birthday { get; } = birthday;

    public List<Pet> pets { get; } = new();

    public override string ToString() => $"{firstName} {lastName}";
}